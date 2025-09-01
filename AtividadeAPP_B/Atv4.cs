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
    public partial class Atv04 : Form
    {
        public Atv04()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, soma, res;

            num1 = Convert.ToDouble(txtnum.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            num3 = Convert.ToDouble(txtnum3.Text);

            soma = num1 + num2 + num3;
            res = soma / 2;

            txtres.Text = res.ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtnum2.Clear();
            txtnum3.Clear();

            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
