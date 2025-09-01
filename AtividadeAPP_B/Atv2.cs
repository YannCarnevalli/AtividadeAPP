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
    public partial class Atv2: Form
    {
        public Atv2()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double vel, temp, dist, lit;

                 vel = Convert.ToDouble(txtvel.Text);
                temp = Convert.ToDouble(txttemp.Text);

            dist = vel * temp;
            lit = dist / 12;

            txtdist.Text = dist.ToString();
            txtLitros.Text = lit.ToString();


        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtLitros.Clear();
            txtdist.Clear();
            txttemp.Clear();
            txtvel.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
