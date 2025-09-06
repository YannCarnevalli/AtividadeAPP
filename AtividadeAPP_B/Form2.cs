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

        private void atividade04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv4 atividade04 = new Atv4();
            atividade04.Show();
        }

        private void atividade01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            txtres atividade01 = new txtres();
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

        private void atividade06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv6 atividade06 = new Atv6();
            atividade06.Show();
        }

        private void atividade07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv7 atividade07 = new Atv7();
            atividade07.Show();
        }

        private void atividade08ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv8 atividade08 = new Atv8();
            atividade08.Show();
        }

        private void atividade09ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv9 atividade9 = new Atv9();
            atividade9.Show();

        }

        private void atividade10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv10 atividade10 = new Atv10();
            atividade10.Show();
        }

        private void atividade11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv11 atividade11 = new Atv11();
            atividade11.Show();
        }

        private void atividade12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv12 atividade12 = new Atv12();
            atividade12.Show();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void atividade05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atv5 atividade5 = new Atv5();
            atividade5.Show();
            
        }
    }
}
