namespace AdvancedHillsCipherImageEncryption
{
    partial class GeradorDeMatrizAutoInvertivel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerar = new System.Windows.Forms.Button();
            this.lvwMatriz = new System.Windows.Forms.ListView();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudModulo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerar.Location = new System.Drawing.Point(713, 61);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 0;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lvwMatriz
            // 
            this.lvwMatriz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwMatriz.GridLines = true;
            this.lvwMatriz.HideSelection = false;
            this.lvwMatriz.Location = new System.Drawing.Point(12, 90);
            this.lvwMatriz.Name = "lvwMatriz";
            this.lvwMatriz.Size = new System.Drawing.Size(776, 319);
            this.lvwMatriz.TabIndex = 2;
            this.lvwMatriz.UseCompatibleStateImageBehavior = false;
            this.lvwMatriz.View = System.Windows.Forms.View.Details;
            // 
            // nudSize
            // 
            this.nudSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSize.Location = new System.Drawing.Point(581, 38);
            this.nudSize.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 20);
            this.nudSize.TabIndex = 3;
            this.nudSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerador de Matriz Auto Invertível";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(503, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tamanho:";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(713, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(517, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Módulo:";
            // 
            // nudModulo
            // 
            this.nudModulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudModulo.Location = new System.Drawing.Point(581, 64);
            this.nudModulo.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudModulo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudModulo.Name = "nudModulo";
            this.nudModulo.Size = new System.Drawing.Size(120, 20);
            this.nudModulo.TabIndex = 7;
            this.nudModulo.Value = new decimal(new int[] {
            251,
            0,
            0,
            0});
            // 
            // GeradorDeMatrizAutoInvertivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudModulo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lvwMatriz);
            this.Controls.Add(this.btnGerar);
            this.Name = "GeradorDeMatrizAutoInvertivel";
            this.Text = "Gerador De Matriz AutoInvertivel";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudModulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ListView lvwMatriz;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudModulo;
    }
}