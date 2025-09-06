namespace AtividadeAPP_B
{
    partial class Atv12
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
            this.lblcod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtres = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblcodigos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblcod.Location = new System.Drawing.Point(35, 146);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(271, 26);
            this.lblcod.TabIndex = 0;
            this.lblcod.Text = "Digite o código do produto:";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtCod.Location = new System.Drawing.Point(305, 143);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(191, 32);
            this.txtCod.TabIndex = 1;
            // 
            // txtres
            // 
            this.txtres.Enabled = false;
            this.txtres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtres.Location = new System.Drawing.Point(184, 214);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(442, 32);
            this.txtres.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(40, 349);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(219, 45);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Verificar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlimpar.Location = new System.Drawing.Point(305, 349);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(219, 45);
            this.btnlimpar.TabIndex = 17;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnvoltar.Location = new System.Drawing.Point(569, 349);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(219, 45);
            this.btnvoltar.TabIndex = 18;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblcodigos
            // 
            this.lblcodigos.AutoSize = true;
            this.lblcodigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblcodigos.Location = new System.Drawing.Point(35, 26);
            this.lblcodigos.Name = "lblcodigos";
            this.lblcodigos.Size = new System.Drawing.Size(415, 26);
            this.lblcodigos.TabIndex = 19;
            this.lblcodigos.Text = "Codigos dos produtos: 100, 101, 102, 103";
            // 
            // Atv12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcodigos);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblcod);
            this.Name = "Atv12";
            this.Text = "Atv12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblcodigos;
    }
}