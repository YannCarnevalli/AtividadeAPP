namespace AtividadeAPP_B
{
    partial class Atv8
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
            this.lblPub = new System.Windows.Forms.Label();
            this.txtPubTotal = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPub.Location = new System.Drawing.Point(73, 92);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(297, 26);
            this.lblPub.TabIndex = 0;
            this.lblPub.Text = "Digite o publico total do jogo: ";
            // 
            // txtPubTotal
            // 
            this.txtPubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPubTotal.Location = new System.Drawing.Point(367, 92);
            this.txtPubTotal.Name = "txtPubTotal";
            this.txtPubTotal.Size = new System.Drawing.Size(160, 32);
            this.txtPubTotal.TabIndex = 1;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRes.Location = new System.Drawing.Point(95, 147);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(236, 26);
            this.lblRes.TabIndex = 2;
            this.lblRes.Text = "A renda total do jogo é:";
            // 
            // txtRes
            // 
            this.txtRes.Enabled = false;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRes.Location = new System.Drawing.Point(367, 144);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(160, 32);
            this.txtRes.TabIndex = 3;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnvoltar.Location = new System.Drawing.Point(552, 407);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(219, 45);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlimpar.Location = new System.Drawing.Point(308, 407);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(219, 45);
            this.btnlimpar.TabIndex = 16;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(45, 407);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(237, 45);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Atv8
            // 
            this.ClientSize = new System.Drawing.Size(842, 526);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtPubTotal);
            this.Controls.Add(this.lblPub);
            this.Name = "Atv8";
            this.Text = "Atv8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.TextBox txtPubTotal;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnCalcular;
    }
}