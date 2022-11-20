namespace AdvancedHillsCipherImageEncryption
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picLogoIF = new System.Windows.Forms.PictureBox();
            this.picImagemOriginal = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picChave = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEscolherImagem = new System.Windows.Forms.Button();
            this.btnEscolherChave = new System.Windows.Forms.Button();
            this.btnSalvarImagemResultado = new System.Windows.Forms.Button();
            this.btnSalvarChave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeeeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geradorDeMatrizAutoInvertivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integrantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtCriptografar = new System.Windows.Forms.RadioButton();
            this.rbtDescriptografar = new System.Windows.Forms.RadioButton();
            this.btnRodar = new System.Windows.Forms.Button();
            this.chkGerarChaveAleatoria = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChave)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "PICC4 - Projeto Interdisciplinar de Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(692, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "Advanced Hill\'s Cipher Image Encryption";
            // 
            // picLogoIF
            // 
            this.picLogoIF.Image = ((System.Drawing.Image)(resources.GetObject("picLogoIF.Image")));
            this.picLogoIF.InitialImage = null;
            this.picLogoIF.Location = new System.Drawing.Point(10, 39);
            this.picLogoIF.Name = "picLogoIF";
            this.picLogoIF.Size = new System.Drawing.Size(101, 103);
            this.picLogoIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoIF.TabIndex = 16;
            this.picLogoIF.TabStop = false;
            // 
            // picImagemOriginal
            // 
            this.picImagemOriginal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picImagemOriginal.Location = new System.Drawing.Point(24, 196);
            this.picImagemOriginal.Name = "picImagemOriginal";
            this.picImagemOriginal.Size = new System.Drawing.Size(288, 288);
            this.picImagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagemOriginal.TabIndex = 19;
            this.picImagemOriginal.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Location = new System.Drawing.Point(18, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 310);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(85, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Imagem Original";
            // 
            // picChave
            // 
            this.picChave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picChave.Location = new System.Drawing.Point(6, 10);
            this.picChave.Name = "picChave";
            this.picChave.Size = new System.Drawing.Size(288, 288);
            this.picChave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChave.TabIndex = 22;
            this.picChave.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.picChave);
            this.groupBox2.Location = new System.Drawing.Point(349, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 310);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // picResultado
            // 
            this.picResultado.Location = new System.Drawing.Point(689, 199);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(288, 288);
            this.picResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResultado.TabIndex = 24;
            this.picResultado.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Location = new System.Drawing.Point(683, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 310);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(389, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Chave de Criptografia";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label5.Location = new System.Drawing.Point(738, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Imagem Resultado";
            // 
            // btnEscolherImagem
            // 
            this.btnEscolherImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEscolherImagem.Location = new System.Drawing.Point(205, 499);
            this.btnEscolherImagem.Name = "btnEscolherImagem";
            this.btnEscolherImagem.Size = new System.Drawing.Size(107, 23);
            this.btnEscolherImagem.TabIndex = 28;
            this.btnEscolherImagem.Text = "Escolher Imagem";
            this.btnEscolherImagem.UseVisualStyleBackColor = true;
            this.btnEscolherImagem.Click += new System.EventHandler(this.btnEscolherImagem_Click);
            // 
            // btnEscolherChave
            // 
            this.btnEscolherChave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEscolherChave.Location = new System.Drawing.Point(349, 499);
            this.btnEscolherChave.Name = "btnEscolherChave";
            this.btnEscolherChave.Size = new System.Drawing.Size(107, 23);
            this.btnEscolherChave.TabIndex = 29;
            this.btnEscolherChave.Text = "Escolher Chave";
            this.btnEscolherChave.UseVisualStyleBackColor = true;
            this.btnEscolherChave.Click += new System.EventHandler(this.btnEscolherChave_Click);
            // 
            // btnSalvarImagemResultado
            // 
            this.btnSalvarImagemResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarImagemResultado.Location = new System.Drawing.Point(876, 502);
            this.btnSalvarImagemResultado.Name = "btnSalvarImagemResultado";
            this.btnSalvarImagemResultado.Size = new System.Drawing.Size(107, 23);
            this.btnSalvarImagemResultado.TabIndex = 32;
            this.btnSalvarImagemResultado.Text = "Salvar Imagem";
            this.btnSalvarImagemResultado.UseVisualStyleBackColor = true;
            this.btnSalvarImagemResultado.Click += new System.EventHandler(this.btnSalvarImagemResultado_Click);
            // 
            // btnSalvarChave
            // 
            this.btnSalvarChave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvarChave.Location = new System.Drawing.Point(542, 499);
            this.btnSalvarChave.Name = "btnSalvarChave";
            this.btnSalvarChave.Size = new System.Drawing.Size(107, 23);
            this.btnSalvarChave.TabIndex = 33;
            this.btnSalvarChave.Text = "Salvar Chave";
            this.btnSalvarChave.UseVisualStyleBackColor = true;
            this.btnSalvarChave.Click += new System.EventHandler(this.btnSalvarChave_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(956, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Alpha 3.0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeeeeToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeeeeToolStripMenuItem
            // 
            this.testeeeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.testeeeeToolStripMenuItem.Name = "testeeeeToolStripMenuItem";
            this.testeeeeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.testeeeeToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geradorDeMatrizAutoInvertivelToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // geradorDeMatrizAutoInvertivelToolStripMenuItem
            // 
            this.geradorDeMatrizAutoInvertivelToolStripMenuItem.Name = "geradorDeMatrizAutoInvertivelToolStripMenuItem";
            this.geradorDeMatrizAutoInvertivelToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.geradorDeMatrizAutoInvertivelToolStripMenuItem.Text = "Gerador de Matriz Auto-Invertivel";
            this.geradorDeMatrizAutoInvertivelToolStripMenuItem.Click += new System.EventHandler(this.geradorDeMatrizAutoInvertivelToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integrantesToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // integrantesToolStripMenuItem
            // 
            this.integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            this.integrantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.integrantesToolStripMenuItem.Text = "Integrantes";
            this.integrantesToolStripMenuItem.Click += new System.EventHandler(this.integrantesToolStripMenuItem_Click);
            // 
            // rbtCriptografar
            // 
            this.rbtCriptografar.AutoSize = true;
            this.rbtCriptografar.Checked = true;
            this.rbtCriptografar.Location = new System.Drawing.Point(26, 508);
            this.rbtCriptografar.Name = "rbtCriptografar";
            this.rbtCriptografar.Size = new System.Drawing.Size(79, 17);
            this.rbtCriptografar.TabIndex = 36;
            this.rbtCriptografar.TabStop = true;
            this.rbtCriptografar.Text = "Criptografar";
            this.rbtCriptografar.UseVisualStyleBackColor = true;
            this.rbtCriptografar.CheckedChanged += new System.EventHandler(this.rbtCriptografar_CheckedChanged);
            // 
            // rbtDescriptografar
            // 
            this.rbtDescriptografar.AutoSize = true;
            this.rbtDescriptografar.Location = new System.Drawing.Point(26, 531);
            this.rbtDescriptografar.Name = "rbtDescriptografar";
            this.rbtDescriptografar.Size = new System.Drawing.Size(97, 17);
            this.rbtDescriptografar.TabIndex = 37;
            this.rbtDescriptografar.Text = "Descriptografar";
            this.rbtDescriptografar.UseVisualStyleBackColor = true;
            this.rbtDescriptografar.CheckedChanged += new System.EventHandler(this.rbtDescriptografar_CheckedChanged);
            // 
            // btnRodar
            // 
            this.btnRodar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRodar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRodar.Location = new System.Drawing.Point(205, 531);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(107, 40);
            this.btnRodar.TabIndex = 38;
            this.btnRodar.Text = "Rodar";
            this.btnRodar.UseVisualStyleBackColor = true;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // chkGerarChaveAleatoria
            // 
            this.chkGerarChaveAleatoria.AutoSize = true;
            this.chkGerarChaveAleatoria.Checked = true;
            this.chkGerarChaveAleatoria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGerarChaveAleatoria.Location = new System.Drawing.Point(26, 554);
            this.chkGerarChaveAleatoria.Name = "chkGerarChaveAleatoria";
            this.chkGerarChaveAleatoria.Size = new System.Drawing.Size(130, 17);
            this.chkGerarChaveAleatoria.TabIndex = 39;
            this.chkGerarChaveAleatoria.Text = "Gerar Chave Aleatória";
            this.chkGerarChaveAleatoria.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 631);
            this.Controls.Add(this.chkGerarChaveAleatoria);
            this.Controls.Add(this.btnRodar);
            this.Controls.Add(this.rbtDescriptografar);
            this.Controls.Add(this.rbtCriptografar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalvarChave);
            this.Controls.Add(this.btnSalvarImagemResultado);
            this.Controls.Add(this.btnEscolherChave);
            this.Controls.Add(this.btnEscolherImagem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picResultado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picImagemOriginal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picLogoIF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Advanced Hill\'s Cipher Image Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChave)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogoIF;
        private System.Windows.Forms.PictureBox picImagemOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picChave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEscolherImagem;
        private System.Windows.Forms.Button btnEscolherChave;
        private System.Windows.Forms.Button btnSalvarImagemResultado;
        private System.Windows.Forms.Button btnSalvarChave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testeeeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integrantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geradorDeMatrizAutoInvertivelToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbtCriptografar;
        private System.Windows.Forms.RadioButton rbtDescriptografar;
        private System.Windows.Forms.Button btnRodar;
        private System.Windows.Forms.CheckBox chkGerarChaveAleatoria;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

