using MathNet.Numerics.LinearAlgebra.Complex;
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

namespace AdvancedHillsCipherImageEncryption
{
    public partial class GeradorDeMatrizAutoInvertivel : Form
    {
        public GeradorDeMatrizAutoInvertivel()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            lvwMatriz.Clear();
            Form1 form1 = new Form1();
            Matrix<Double> matriz = form1.matrizAutoInvertivel(Convert.ToInt32(nudSize.Value), Convert.ToInt32(nudModulo.Value));
            for(int i = 0; i < matriz.RowCount+1; i++)
            {
                lvwMatriz.Columns.Add(i.ToString());
            }
            for (int i = 0; i < matriz.RowCount; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i+1).ToString();
                for (int j = 0; j < matriz.ColumnCount; j++)
                {
                    item.SubItems.Add(matriz[i, j].ToString());
                }
                lvwMatriz.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvwMatriz.Clear();
        }
    }
}
