namespace PesoIdeal
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnMulher = new System.Windows.Forms.RadioButton();
            this.rbtnHomem = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPesoAtual = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(61, 33);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Location = new System.Drawing.Point(61, 82);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(76, 17);
            this.lblPesoAtual.TabIndex = 1;
            this.lblPesoAtual.Text = "Peso Atual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHomem);
            this.groupBox1.Controls.Add(this.rbtnMulher);
            this.groupBox1.Location = new System.Drawing.Point(233, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gênero";
            // 
            // rbtnMulher
            // 
            this.rbtnMulher.AutoSize = true;
            this.rbtnMulher.Checked = true;
            this.rbtnMulher.Location = new System.Drawing.Point(26, 38);
            this.rbtnMulher.Name = "rbtnMulher";
            this.rbtnMulher.Size = new System.Drawing.Size(72, 21);
            this.rbtnMulher.TabIndex = 0;
            this.rbtnMulher.TabStop = true;
            this.rbtnMulher.Text = "Mulher";
            this.rbtnMulher.UseVisualStyleBackColor = true;
            // 
            // rbtnHomem
            // 
            this.rbtnHomem.AutoSize = true;
            this.rbtnHomem.Location = new System.Drawing.Point(26, 65);
            this.rbtnHomem.Name = "rbtnHomem";
            this.rbtnHomem.Size = new System.Drawing.Size(77, 21);
            this.rbtnHomem.TabIndex = 1;
            this.rbtnHomem.Text = "Homem";
            this.rbtnHomem.UseVisualStyleBackColor = true;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(64, 53);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 22);
            this.txtAltura.TabIndex = 3;
            // 
            // txtPesoAtual
            // 
            this.txtPesoAtual.Location = new System.Drawing.Point(64, 109);
            this.txtPesoAtual.Name = "txtPesoAtual";
            this.txtPesoAtual.Size = new System.Drawing.Size(100, 22);
            this.txtPesoAtual.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(166, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 42);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPesoAtual);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Peso Ideal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHomem;
        private System.Windows.Forms.RadioButton rbtnMulher;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPesoAtual;
        private System.Windows.Forms.Button btnCalcular;
    }
}

