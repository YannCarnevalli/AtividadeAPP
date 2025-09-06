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
    public partial class Atv12 : Form
    {
        public Atv12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string cod;
            cod = txtCod.Text;

            switch (cod)
            {
                case "100":
                        txtres.Text = "Cachorro quente 25 R$";
                    break;

                case "101":
                        txtres.Text = "Bauru 15 R$";
                    break;

                case "102":
                        txtres.Text = "X-Burguer 35 R$";
                    break;

                case "103":
                        txtres.Text = "Triplo X-Burguer 47 R$";
                    break;

                 default: 
                    txtres.Text = "Codigo invalido!";
                    break;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtres.Clear();

            txtCod.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
