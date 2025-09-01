namespace AtividadeAPP_B
{
    partial class Atv3
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
            this.lblreal = new System.Windows.Forms.Label();
            this.lblequivale = new System.Windows.Forms.Label();
            this.txtreal = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.lbldolares = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblreal
            // 
            this.lblreal.AutoSize = true;
            this.lblreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblreal.Location = new System.Drawing.Point(62, 53);
            this.lblreal.Name = "lblreal";
            this.lblreal.Size = new System.Drawing.Size(299, 31);
            this.lblreal.TabIndex = 0;
            this.lblreal.Text = "Digite o preço em reais:";
            // 
            // lblequivale
            // 
            this.lblequivale.AutoSize = true;
            this.lblequivale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblequivale.Location = new System.Drawing.Point(12, 212);
            this.lblequivale.Name = "lblequivale";
            this.lblequivale.Size = new System.Drawing.Size(361, 31);
            this.lblequivale.TabIndex = 1;
            this.lblequivale.Text = "O resultado da conversão é: ";
            // 
            // txtreal
            // 
            this.txtreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtreal.Location = new System.Drawing.Point(379, 50);
            this.txtreal.Name = "txtreal";
            this.txtreal.Size = new System.Drawing.Size(257, 38);
            this.txtreal.TabIndex = 2;
            // 
            // txtres
            // 
            this.txtres.Enabled = false;
            this.txtres.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtres.Location = new System.Drawing.Point(379, 209);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(257, 38);
            this.txtres.TabIndex = 3;
            // 
            // lbldolares
            // 
            this.lbldolares.AutoSize = true;
            this.lbldolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbldolares.Location = new System.Drawing.Point(62, 110);
            this.lbldolares.Name = "lbldolares";
            this.lbldolares.Size = new System.Drawing.Size(284, 31);
            this.lbldolares.TabIndex = 4;
            this.lbldolares.Text = "Digite o valor do dolar:";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(38, 315);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(200, 55);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtdolar
            // 
            this.txtdolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdolar.Location = new System.Drawing.Point(379, 110);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(257, 38);
            this.txtdolar.TabIndex = 6;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(308, 315);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(200, 55);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(565, 315);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(200, 55);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar ";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Atv3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbldolares);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtreal);
            this.Controls.Add(this.lblequivale);
            this.Controls.Add(this.lblreal);
            this.Name = "Atv3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Atv3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblreal;
        private System.Windows.Forms.Label lblequivale;
        private System.Windows.Forms.TextBox txtreal;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Label lbldolares;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}