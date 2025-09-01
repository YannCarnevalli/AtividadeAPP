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
    public partial class Atv7 : Form
    {
        public Atv7()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double alturaR, baseR, area;

            alturaR = Convert.ToDouble(txtAltura.Text);
            baseR = Convert.ToDouble(txtBase.Text);

            area = alturaR * baseR;

            txtArea.Text = Convert.ToString(area);



        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtBase.Clear();
            txtArea.Clear();
            txtAltura.Focus();
        }
    }
}
