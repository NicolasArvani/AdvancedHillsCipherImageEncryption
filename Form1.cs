using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Data.Text;


namespace AdvancedHillsCipherImageEncryption
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        /*_____                                  _____                    
         |  ___|   _ _ __   ___ ___   ___  ___  |  ___|__  _ __ _ __ ___  
         | |_ | | | | '_ \ / __/ _ \ / _ \/ __| | |_ / _ \| '__| '_ ` _ \ 
         |  _|| |_| | | | | (_| (_) |  __/\__ \ |  _| (_) | |  | | | | | |
         |_|   \__,_|_| |_|\___\___/ \___||___/ |_|  \___/|_|  |_| |_| |_|*/

        
        const int MOD = 251;

        private void btnRodar_Click(object sender, EventArgs e)
        {

            if (!checkImages())
            {
                return;
            }
            Bitmap original = (Bitmap)picImagemOriginal.Image;
            if (rbtCriptografar.Checked) //Criptografar
            {

                if (checkColorAboveMod(original))
                {
                    original = redutorDeCores(original);
                }
                Matrix<Double> matrixChave;
                if (chkGerarChaveAleatoria.Checked)
                {
                    matrixChave = matrizAutoInvertivel(original.Width, MOD);
                    Bitmap chave = MatrixToBitmap(matrixChave, matrixChave, matrixChave);
                    picChave.Image = chave;
                }
                else
                {
                    Bitmap chave = (Bitmap)picChave.Image;
                    matrixChave = ImageToMatrixRGB(chave)[0];
                }

                Bitmap criptografada = CriptografarV2(original, matrixChave);
                picResultado.Image = criptografada;
            }

            else //Descriptografar
            {
                Bitmap chave = (Bitmap)picChave.Image;
                Matrix<Double> matrixChave = ImageToMatrixRGB(chave)[0];
                Bitmap descriptografada = CriptografarV2(original, matrixChave);
                picResultado.Image = descriptografada;
            }
        }
        private Matrix<Double> cifraDeHillAvancada(Matrix<Double> chave, Matrix<Double> original)
        {

            return null;
        }
        private void rbtDescriptografar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDescriptografar.Checked)
            {
                chkGerarChaveAleatoria.Checked = false;
                chkGerarChaveAleatoria.Enabled = false;
            }
        }
        private void rbtCriptografar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCriptografar.Checked)
            {
                chkGerarChaveAleatoria.Enabled = true;
                chkGerarChaveAleatoria.Checked = true;
            }
        }
        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }
        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            EnviarImagem(picImagemOriginal);
        }
        private void btnEscolherChave_Click(object sender, EventArgs e)
        {
            EnviarImagem(picChave);
        }
        private void btnSalvarChave_Click(object sender, EventArgs e)
        {
            SalvarImagem(picChave);
        }
        private void btnSalvarImagemResultado_Click(object sender, EventArgs e)
        {
            SalvarImagem(picResultado);
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* _____                                     _                                   
          |  ___|   _ _ __   ___ ___   ___  ___     / \  _   ___  _(_) (_) __ _ _ __ ___  ___ 
          | |_ | | | | '_ \ / __/ _ \ / _ \/ __|   / _ \| | | \ \/ / | | |/ _` | '__/ _ \/ __|
          |  _|| |_| | | | | (_| (_) |  __/\__ \  / ___ \ |_| |>  <| | | | (_| | | |  __/\__ \
          |_|   \__,_|_| |_|\___\___/ \___||___/ /_/   \_\__,_/_/\_\_|_|_|\__,_|_|  \___||___/*/


        //Recebe 3 Matrizes Separadas para RGB
        private Bitmap MatrixToBitmap(Matrix<Double> R, Matrix<Double> G, Matrix<Double> B)
        {
            int row = R.RowCount;
            int column = R.ColumnCount;

            if (G.ColumnCount != column || B.ColumnCount != column)
                MessageBox.Show("Matriz RGB de tamanhos diferentes!");

            if (G.RowCount != row || B.RowCount != row)
                MessageBox.Show("Matriz RGB de tamanhos diferentes!");

            Bitmap img = new Bitmap(row, column);

            Color cor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    cor = Color.FromArgb(255, (int)R[i, j], (int)G[i, j], (int)B[i, j]);
                    img.SetPixel(i, j, cor);
                }
            }
            return img;
        }

        //Recebe Array de Matrizes contendo RGB
        private Bitmap MatrixToBitmap(Matrix<Double>[] RGB) //RGB[0] == R ; RGB[1] == G ; RGB[2] == B
        {
            int row = RGB[0].RowCount;
            int column = RGB[0].ColumnCount;
            
            Bitmap img = new Bitmap(row, column);

            Color cor;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    cor = Color.FromArgb(255, (int)RGB[0][i, j], (int)RGB[1][i, j], (int)RGB[2][i, j]);
                    img.SetPixel(i, j, cor);
                }
            }
            return img;
        }
        
        
        private Matrix<Double>[] ImageToMatrixRGB(Bitmap Image)
        {
            Matrix<Double>[] imageRGB = new Matrix<Double>[3];
            imageRGB[0] = Matrix<Double>.Build.Dense(Image.Height, Image.Width); //R
            imageRGB[1] = Matrix<Double>.Build.Dense(Image.Height, Image.Width); //G
            imageRGB[2] = Matrix<Double>.Build.Dense(Image.Height, Image.Width); //B

            Color cor;
            for (int i = 0; i < Image.Height; i++)
            {
                for (int j = 0; j < Image.Width; j++)
                {
                    cor = Image.GetPixel(i, j);
                    imageRGB[0][i, j] = cor.R;
                    imageRGB[1][i, j] = cor.G;
                    imageRGB[2][i, j] = cor.B;
                }
            }

            return imageRGB;

        }


        private Bitmap redutorDeCores(Bitmap Original)
        {
            Bitmap reduzida = new Bitmap(Original);
            Color cor;
            int qtd = 0;
            for (int i = 0; i < Original.Height; i++)
            {
                for (int j = 0; j < Original.Width; j++)
                {
                    cor = Original.GetPixel(i, j);
                    int R = cor.R;
                    int G = cor.G;
                    int B = cor.B;
                    if (R > MOD - 1 || G > MOD - 1 || B > MOD - 1)
                    {
                        if (R > MOD - 1)
                            R = MOD - 1;
                        if (G > MOD - 1)
                            G = MOD - 1;
                        if (B > MOD - 1)
                            B = MOD - 1;
                        qtd++;
                    }
                    reduzida.SetPixel(i, j, Color.FromArgb(255, R, G, B));
                }
            }

            return reduzida;
        }

        private bool checkColorAboveMod(Bitmap image)
        {
            bool check = false;
            for(int i = 0; i < image.Height; i++)
            {
                for(int j = 0; j < image.Height; j++)
                {
                    if(image.GetPixel(i,j).R >= MOD || image.GetPixel(i, j).G >= MOD || image.GetPixel(i, j).B >= MOD)
                    {
                        check = true;
                    }
                }
            }
            return check;
        }

        public Matrix<Double> matrizAutoInvertivel(int tam, int mod)
        {
            //Novel Methods of Generating Self-Invertible Matrix for Hill Cipher Algorithm 4.4

            Matrix<Double> completa = Matrix<Double>.Build.Dense(tam, tam);
            Matrix<Double> A11 = Matrix<Double>.Build.Dense(tam / 2, tam / 2);
            Matrix<Double> A21 = Matrix<Double>.Build.Dense(tam / 2, tam / 2);
            Matrix<Double> A12 = Matrix<Double>.Build.Dense(tam / 2, tam / 2);
            Matrix<Double> A22 = Matrix<Double>.Build.Dense(tam / 2, tam / 2);

            Random r = new Random();

            //Step 1
            for (int i = 0; i < tam / 2; i++)
                for (int j = 0; j < tam / 2; j++)
                    A22[i, j] = r.Next() % mod; 

            //Step 2
            for (int i = 0; i < tam / 2; i++)
                for (int j = 0; j < tam / 2; j++)
                    A11[i, j] = -(A22[i, j]);

            A11 = A11.Modulus(mod);

            //Escalar aleatorio
            int k = r.Next(1, mod - 1);


            //Step 3 Usando a Operacao de Subtracao
            A12 = Matrix<Double>.Build.DenseIdentity(tam / 2, tam / 2) - A11;
            A12 = A12.Multiply(k).Modulus(mod);
            
            //Step 4 Usando a Operacao de Adicao
            A21 = (Matrix<Double>.Build.DenseIdentity(tam / 2, tam / 2) + A11);
            A21 = A21.Modulus(mod);

            for (int i = 0; i < tam / 2; i++) //Divisao de Modulo para A22 pois precisa do inverso de k (que resulta em uma fracao)
            {
                for (int j = 0; j < tam / 2; j++)
                {
                    for (int z = 0; z < mod; z++)
                    {       
                        if (A21[i, j] == (z * k) % mod)
                        {
                            A21[i, j] = z;
                            break;
                        }
                    }
                }
            }

            //Step 5 Montagem da Matriz Completa
            for (int i = 0; i < tam / 2; i++)
            {
                for (int j = 0; j < tam / 2; j++)
                {
                    completa[i, j] = A11[i, j];
                    completa[i, j + tam / 2] = A12[i, j];
                    completa[i + tam / 2, j] = A21[i, j];
                    completa[i + tam / 2, j + tam / 2] = A22[i, j];
                }

            }
               
            return completa;
        }

        private Bitmap CriptografarV2(Bitmap imagemOriginal, Matrix<Double> key)
        {

            Matrix<Double>[] RGB = ImageToMatrixRGB(imagemOriginal);

            RGB[0] = cifraDeHillAdv(RGB[0], key, MOD);
            RGB[1] = cifraDeHillAdv(RGB[1], key, MOD);
            RGB[2] = cifraDeHillAdv(RGB[2], key, MOD);

            Bitmap criptografada = MatrixToBitmap(RGB);

            return criptografada;

        }

        private Matrix<Double> cifraDeHillAdv(Matrix<Double> originalMatrix, Matrix<Double> key, int modulo)
        {

            Matrix<Double> resultado = Matrix<Double>.Build.Dense(originalMatrix.RowCount, originalMatrix.ColumnCount);
            resultado = key.Multiply(originalMatrix);
            resultado = resultado.Modulus(modulo);
            resultado = resultado.Transpose();
            resultado = key.Multiply(resultado).Modulus(modulo);

            return resultado;
        }


        private bool checkImages()
        {
            if (picImagemOriginal.Image == null)
            {
                MessageBox.Show("Escolha uma imagem antes!");
                return false;
            }
            if (picImagemOriginal.Image.Width != picImagemOriginal.Image.Height)
            {
                MessageBox.Show("A imagem escolhida deve ser quadrada!");
                return false;
            }
            if (!chkGerarChaveAleatoria.Checked && picChave.Image == null)
            {
                MessageBox.Show("Escolha uma chave antes!");
                return false;
            }
            return true;
        }



        private void EnviarImagem(PictureBox picturebox)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagem | *.png; *.jpeg; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap Imagem = new Bitmap(ofd.FileName);
                picturebox.Image = Imagem;
            }
        }

        private void SalvarImagem(PictureBox picturebox)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Imagem (*.png) | *.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                picturebox.Image.Save(sfd.FileName);
                MessageBox.Show("Imagem salva com sucesso!", "Salvar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Imagem não foi salva, verifique novamente!", "Salvar Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void geradorDeMatrizAutoInvertivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeradorDeMatrizAutoInvertivel gerador = new GeradorDeMatrizAutoInvertivel();
            gerador.Show();
        }
    }
}
