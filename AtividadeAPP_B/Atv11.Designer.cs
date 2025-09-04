namespace AtividadeAPP_B
{
    partial class Atv11
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblClasse = new System.Windows.Forms.Label();
            this.txtClasse = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAltura.Location = new System.Drawing.Point(48, 67);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(193, 26);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Digite a sua altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPeso.Location = new System.Drawing.Point(48, 112);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(186, 26);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Digite o seu peso:";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAltura.Location = new System.Drawing.Point(266, 61);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(194, 32);
            this.txtAltura.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPeso.Location = new System.Drawing.Point(266, 109);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(194, 32);
            this.txtPeso.TabIndex = 3;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblIMC.Location = new System.Drawing.Point(57, 200);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(58, 26);
            this.lblIMC.TabIndex = 4;
            this.lblIMC.Text = "IMC:";
            // 
            // txtIMC
            // 
            this.txtIMC.Enabled = false;
            this.txtIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtIMC.Location = new System.Drawing.Point(132, 197);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(143, 32);
            this.txtIMC.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncalcular.Location = new System.Drawing.Point(22, 368);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(237, 45);
            this.btncalcular.TabIndex = 11;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblClasse.Location = new System.Drawing.Point(30, 246);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(85, 26);
            this.lblClasse.TabIndex = 12;
            this.lblClasse.Text = "Classe:";
            // 
            // txtClasse
            // 
            this.txtClasse.Enabled = false;
            this.txtClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtClasse.Location = new System.Drawing.Point(132, 246);
            this.txtClasse.Name = "txtClasse";
            this.txtClasse.Size = new System.Drawing.Size(244, 32);
            this.txtClasse.TabIndex = 13;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlimpar.Location = new System.Drawing.Point(275, 368);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(237, 45);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnvoltar.Location = new System.Drawing.Point(535, 368);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(237, 45);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Atv11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtClasse);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Name = "Atv11";
            this.Text = "Atv11";
            this.Load += new System.EventHandler(this.Atv11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.TextBox txtClasse;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}