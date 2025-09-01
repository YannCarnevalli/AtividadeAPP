namespace AtividadeAPP_B
{
    partial class frmmenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividade05ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividade01ToolStripMenuItem,
            this.atividade02ToolStripMenuItem,
            this.atividade03ToolStripMenuItem,
            this.atividade04ToolStripMenuItem,
            this.atividade05ToolStripMenuItem});
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            // 
            // atividade01ToolStripMenuItem
            // 
            this.atividade01ToolStripMenuItem.Name = "atividade01ToolStripMenuItem";
            this.atividade01ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividade01ToolStripMenuItem.Text = "Atividade01";
            this.atividade01ToolStripMenuItem.Click += new System.EventHandler(this.atividade01ToolStripMenuItem_Click);
            // 
            // atividade02ToolStripMenuItem
            // 
            this.atividade02ToolStripMenuItem.Name = "atividade02ToolStripMenuItem";
            this.atividade02ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividade02ToolStripMenuItem.Text = "Atividade02";
            this.atividade02ToolStripMenuItem.Click += new System.EventHandler(this.atividade02ToolStripMenuItem_Click);
            // 
            // atividade03ToolStripMenuItem
            // 
            this.atividade03ToolStripMenuItem.Name = "atividade03ToolStripMenuItem";
            this.atividade03ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividade03ToolStripMenuItem.Text = "Atividade03";
            this.atividade03ToolStripMenuItem.Click += new System.EventHandler(this.atividade03ToolStripMenuItem_Click);
            // 
            // atividade04ToolStripMenuItem
            // 
            this.atividade04ToolStripMenuItem.Name = "atividade04ToolStripMenuItem";
            this.atividade04ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividade04ToolStripMenuItem.Text = "Atividade04";
            this.atividade04ToolStripMenuItem.Click += new System.EventHandler(this.atividade04ToolStripMenuItem_Click);
            // 
            // atividade05ToolStripMenuItem
            // 
            this.atividade05ToolStripMenuItem.Name = "atividade05ToolStripMenuItem";
            this.atividade05ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividade05ToolStripMenuItem.Text = "Atividade05";
            this.atividade05ToolStripMenuItem.Click += new System.EventHandler(this.atividade05ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbltitulo.Location = new System.Drawing.Point(239, 61);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(239, 31);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Atividade de T.P.A";
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblsubtitulo.Location = new System.Drawing.Point(130, 103);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(498, 24);
            this.lblsubtitulo.TabIndex = 2;
            this.lblsubtitulo.Text = "5 Atividades de programação no visual studio (em Csharp)";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividade01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade03ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade04ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividade05ToolStripMenuItem;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblsubtitulo;
    }
}