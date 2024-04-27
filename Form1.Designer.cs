namespace Seletor_de_Genero
{
    partial class FrmPrincipal
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.rbHomem = new System.Windows.Forms.RadioButton();
            this.rbMulher = new System.Windows.Forms.RadioButton();
            this.btnConfir = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.rbOutro = new System.Windows.Forms.RadioButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl1.Location = new System.Drawing.Point(126, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(187, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Selecione seu Sexo";
            // 
            // rbHomem
            // 
            this.rbHomem.AutoSize = true;
            this.rbHomem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbHomem.Location = new System.Drawing.Point(18, 98);
            this.rbHomem.Name = "rbHomem";
            this.rbHomem.Size = new System.Drawing.Size(74, 21);
            this.rbHomem.TabIndex = 1;
            this.rbHomem.TabStop = true;
            this.rbHomem.Text = "Homem";
            this.rbHomem.UseVisualStyleBackColor = true;
            // 
            // rbMulher
            // 
            this.rbMulher.AutoSize = true;
            this.rbMulher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbMulher.Location = new System.Drawing.Point(18, 125);
            this.rbMulher.Name = "rbMulher";
            this.rbMulher.Size = new System.Drawing.Size(69, 21);
            this.rbMulher.TabIndex = 2;
            this.rbMulher.TabStop = true;
            this.rbMulher.Text = "Mulher";
            this.rbMulher.UseVisualStyleBackColor = true;
            // 
            // btnConfir
            // 
            this.btnConfir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnConfir.Location = new System.Drawing.Point(15, 211);
            this.btnConfir.Name = "btnConfir";
            this.btnConfir.Size = new System.Drawing.Size(111, 44);
            this.btnConfir.TabIndex = 4;
            this.btnConfir.Text = "Confirmar";
            this.btnConfir.UseVisualStyleBackColor = true;
            this.btnConfir.Click += new System.EventHandler(this.btnConfir_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl2.Location = new System.Drawing.Point(12, 285);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(78, 17);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Selecionou";
            // 
            // txtbox1
            // 
            this.txtbox1.Enabled = false;
            this.txtbox1.Location = new System.Drawing.Point(12, 305);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(278, 20);
            this.txtbox1.TabIndex = 6;
            // 
            // rbOutro
            // 
            this.rbOutro.AutoSize = true;
            this.rbOutro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbOutro.Location = new System.Drawing.Point(18, 152);
            this.rbOutro.Name = "rbOutro";
            this.rbOutro.Size = new System.Drawing.Size(74, 21);
            this.rbOutro.TabIndex = 7;
            this.rbOutro.TabStop = true;
            this.rbOutro.Text = "Outro...";
            this.rbOutro.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(12, 403);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(96, 35);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.rbOutro);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnConfir);
            this.Controls.Add(this.rbMulher);
            this.Controls.Add(this.rbHomem);
            this.Controls.Add(this.lbl1);
            this.Name = "FrmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton rbHomem;
        private System.Windows.Forms.RadioButton rbMulher;
        private System.Windows.Forms.Button btnConfir;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.RadioButton rbOutro;
        private System.Windows.Forms.Button btnFechar;
    }
}

