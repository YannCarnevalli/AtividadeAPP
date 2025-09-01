namespace AtividadeAPP_B
{
    partial class Atv2
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
            this.lblvel = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.txtvel = new System.Windows.Forms.TextBox();
            this.txttemp = new System.Windows.Forms.TextBox();
            this.txtdist = new System.Windows.Forms.TextBox();
            this.lbldist = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.lblLitrosUsados = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblvel
            // 
            this.lblvel.AutoSize = true;
            this.lblvel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblvel.Location = new System.Drawing.Point(48, 95);
            this.lblvel.Name = "lblvel";
            this.lblvel.Size = new System.Drawing.Size(350, 31);
            this.lblvel.TabIndex = 0;
            this.lblvel.Text = "Digite a Velocidade (Km/h): ";
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbltemp.Location = new System.Drawing.Point(12, 151);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(425, 31);
            this.lbltemp.TabIndex = 1;
            this.lbltemp.Text = "Digite o tempo da viagem (Horas):";
            // 
            // txtvel
            // 
            this.txtvel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtvel.Location = new System.Drawing.Point(444, 94);
            this.txtvel.Name = "txtvel";
            this.txtvel.Size = new System.Drawing.Size(272, 32);
            this.txtvel.TabIndex = 4;
            // 
            // txttemp
            // 
            this.txttemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txttemp.Location = new System.Drawing.Point(444, 154);
            this.txttemp.Name = "txttemp";
            this.txttemp.Size = new System.Drawing.Size(272, 32);
            this.txttemp.TabIndex = 5;
            // 
            // txtdist
            // 
            this.txtdist.Enabled = false;
            this.txtdist.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtdist.Location = new System.Drawing.Point(444, 216);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(272, 38);
            this.txtdist.TabIndex = 7;
            // 
            // lbldist
            // 
            this.lbldist.AutoSize = true;
            this.lbldist.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbldist.Location = new System.Drawing.Point(48, 216);
            this.lbldist.Name = "lbldist";
            this.lbldist.Size = new System.Drawing.Size(322, 31);
            this.lbldist.TabIndex = 8;
            this.lbldist.Text = "A distância da viagem foi:";
            // 
            // calcular
            // 
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calcular.Location = new System.Drawing.Point(54, 388);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(237, 45);
            this.calcular.TabIndex = 9;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // lblLitrosUsados
            // 
            this.lblLitrosUsados.AutoSize = true;
            this.lblLitrosUsados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLitrosUsados.Location = new System.Drawing.Point(12, 273);
            this.lblLitrosUsados.Name = "lblLitrosUsados";
            this.lblLitrosUsados.Size = new System.Drawing.Size(407, 31);
            this.lblLitrosUsados.TabIndex = 10;
            this.lblLitrosUsados.Text = "A quantidade de litros gastos foi:";
            // 
            // txtLitros
            // 
            this.txtLitros.Enabled = false;
            this.txtLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLitros.Location = new System.Drawing.Point(444, 273);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(272, 38);
            this.txtLitros.TabIndex = 11;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnlimpar.Location = new System.Drawing.Point(342, 388);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(219, 45);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnvoltar.Location = new System.Drawing.Point(603, 388);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(219, 45);
            this.btnvoltar.TabIndex = 13;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // Atv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 628);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblLitrosUsados);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.lbldist);
            this.Controls.Add(this.txtdist);
            this.Controls.Add(this.txttemp);
            this.Controls.Add(this.txtvel);
            this.Controls.Add(this.lbltemp);
            this.Controls.Add(this.lblvel);
            this.Name = "Atv2";
            this.Text = "                       ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblvel;
        private System.Windows.Forms.TextBox txtvel;
        private System.Windows.Forms.TextBox txttemp;
        private System.Windows.Forms.TextBox txtdist;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Label lbldist;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label lblLitrosUsados;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}