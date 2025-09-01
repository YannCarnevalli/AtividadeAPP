namespace AtividadeAPP_B
{
    partial class Atv01
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
            this.lbldigite = new System.Windows.Forms.Label();
            this.txtgraus = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtfahre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbldigite
            // 
            this.lbldigite.AutoSize = true;
            this.lbldigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbldigite.Location = new System.Drawing.Point(146, 108);
            this.lbldigite.Name = "lbldigite";
            this.lbldigite.Size = new System.Drawing.Size(469, 31);
            this.lbldigite.TabIndex = 0;
            this.lbldigite.Text = "Digite a temperatura em graus celsius\r\n";
            // 
            // txtgraus
            // 
            this.txtgraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtgraus.Location = new System.Drawing.Point(666, 111);
            this.txtgraus.Name = "txtgraus";
            this.txtgraus.Size = new System.Drawing.Size(268, 32);
            this.txtgraus.TabIndex = 1;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(193, 457);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(179, 60);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(463, 457);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(179, 60);
            this.btnlimpar.TabIndex = 3;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(728, 457);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(179, 60);
            this.btnvoltar.TabIndex = 4;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblresultado.Location = new System.Drawing.Point(160, 228);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(394, 31);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "A temperatura em fahrenheit é: \r\n";
            // 
            // txtfahre
            // 
            this.txtfahre.Enabled = false;
            this.txtfahre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtfahre.Location = new System.Drawing.Point(595, 227);
            this.txtfahre.Name = "txtfahre";
            this.txtfahre.Size = new System.Drawing.Size(268, 32);
            this.txtfahre.TabIndex = 6;
            // 
            // Atv01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 666);
            this.Controls.Add(this.txtfahre);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtgraus);
            this.Controls.Add(this.lbldigite);
            this.Name = "Atv01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldigite;
        private System.Windows.Forms.TextBox txtgraus;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtfahre;
    }
}

