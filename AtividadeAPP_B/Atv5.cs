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
    public partial class Atv05 : Form
    {
        public Atv05()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double r, area;
            r = Convert.ToDouble(txtraio.Text);
            area = 3.14 * Math.Pow(r, 2);

            txtres.Text = area.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtraio.Clear();
            txtres.Clear();

            txtraio.Focus();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
