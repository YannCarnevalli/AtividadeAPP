namespace AtividadeAPP_B
{
    partial class Atv9
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
            this.lblQuant = new System.Windows.Forms.Label();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.lblTot = new System.Windows.Forms.Label();
            this.txttot = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblQuant.Location = new System.Drawing.Point(41, 59);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(358, 25);
            this.lblQuant.TabIndex = 0;
            this.lblQuant.Text = "Digite a quantidade de livros comprados";
            // 
            // txtquant
            // 
            this.txtquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtquant.Location = new System.Drawing.Point(418, 59);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(100, 30);
            this.txtquant.TabIndex = 1;
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTot.Location = new System.Drawing.Point(87, 178);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(236, 25);
            this.lblTot.TabIndex = 2;
            this.lblTot.Text = "O preço total a ser pago é";
            // 
            // txttot
            // 
            this.txttot.Enabled = false;
            this.txttot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txttot.Location = new System.Drawing.Point(428, 171);
            this.txttot.Name = "txttot";
            this.txttot.Size = new System.Drawing.Size(100, 30);
            this.txttot.TabIndex = 3;
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calcular.Location = new System.Drawing.Point(46, 347);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(237, 45);
            this.calcular.TabIndex = 10;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlimpar.Location = new System.Drawing.Point(309, 347);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(219, 45);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnvoltar.Location = new System.Drawing.Point(553, 347);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(219, 45);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Atv9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.txttot);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.lblQuant);
            this.Name = "Atv9";
            this.Text = "Atv9";
            this.Load += new System.EventHandler(this.Atv9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.TextBox txttot;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}