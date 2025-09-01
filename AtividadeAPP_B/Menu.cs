using AtividadeAPP_B;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAPP_B
{
    public partial class frmmenu: Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void atividade01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv01 atividade01 = new Atv01();
            atividade01.Show();
        }

        private void atividade02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv2 atividade02 = new Atv2();
            atividade02.Show();

        }

        private void atividade03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv3 atividade03 = new Atv3();
            atividade03.Show();
        }

        private void atividade04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv04 atividade04 = new Atv04();
            atividade04.Show();
        }

        private void atividade05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv05 atividade05 = new Atv05();
            atividade05.Show();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }
    }
    }
}