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
    public partial class Atv5 : Form
    {
        public Atv5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double r, area;
            r = Convert.ToDouble(txtRaio.Text);
            area = 3.14 * Math.Pow(r, 2);

            txtRes.Text = area.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtRaio.Clear();
            txtRes.Clear();

            txtRaio.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void Atv5_Load(object sender, EventArgs e)
        {

        }
    }
}
