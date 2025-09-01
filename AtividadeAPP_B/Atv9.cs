using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAPP_B
{
    public partial class Atv9 : Form
    {
        public Atv9()
        {
            InitializeComponent();
        }

        private void Atv9_Load(object sender, EventArgs e)
        {
             
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double nlivro, preco, total;

                nlivro = Convert.ToDouble(txtquant.Text);

            if (nlivro <= 10)
            {
                preco = 12;
            }
            else
            {
                preco = 8;
            }
            total = nlivro * preco;
            txttot.Text = total.ToString();

           

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtquant.Clear();
            txttot.Clear();
            txtquant.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
            ;

        }
    }
}
