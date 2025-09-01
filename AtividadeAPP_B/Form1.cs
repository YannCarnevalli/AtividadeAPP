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
    public partial class txtres: Form
    {
        public txtres()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double celsius, fahre;
                celsius = Convert.ToDouble(txtgraus.Text);
            fahre = (celsius * 1.8) + 32;

            txtfahre.Text = fahre.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtgraus.Clear();
            txtfahre.Clear();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
