namespace AtividadeAPP_B
{
    partial class Atv05
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
            this.lblraio = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.txtres = new System.Windows.Forms.TextBox();
            this.txtraio = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblraio
            // 
            this.lblraio.AutoSize = true;
            this.lblraio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblraio.Location = new System.Drawing.Point(29, 64);
            this.lblraio.Name = "lblraio";
            this.lblraio.Size = new System.Drawing.Size(338, 29);
            this.lblraio.TabIndex = 0;
            this.lblraio.Text = "Digite o raio da circunfêrencia:";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblres.Location = new System.Drawing.Point(59, 128);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(297, 29);
            this.lblres.TabIndex = 1;
            this.lblres.Text = "A area da circunfêrencia é:";
            // 
            // txtres
            // 
            this.txtres.Enabled = false;
            this.txtres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtres.Location = new System.Drawing.Point(373, 128);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(188, 29);
            this.txtres.TabIndex = 2;
            // 
            // txtraio
            // 
            this.txtraio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtraio.Location = new System.Drawing.Point(373, 64);
            this.txtraio.Name = "txtraio";
            this.txtraio.Size = new System.Drawing.Size(188, 29);
            this.txtraio.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btncalcular.Location = new System.Drawing.Point(64, 233);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(148, 39);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlimpar.Location = new System.Drawing.Point(255, 233);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(148, 39);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnvoltar.Location = new System.Drawing.Point(437, 233);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(148, 39);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Atv05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtraio);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblraio);
            this.Name = "Atv05";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblraio;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.TextBox txtraio;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}