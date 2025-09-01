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
    public partial class Atv6 : Form
    {
        public Atv6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, media;

            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2= Convert.ToDouble(txtNota2.Text);
            nota3= Convert.ToDouble(txtNota3.Text);
            media= (nota1*2) + (nota2*3) + (nota3*5) / 10;
            TxtMedia.Text= media.ToString();
         
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota1.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
