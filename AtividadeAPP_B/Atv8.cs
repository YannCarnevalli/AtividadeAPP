using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAPP_B
{
    public partial class Atv8 : Form
    {
        public Atv8()
        {
            InitializeComponent();
        }

       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double popular, geral, arquibancada, cadeiras, totpubl, rdp, rdg, rda, rdc, rendatot;

            totpubl = Convert.ToDouble(txtPubTotal.Text);
            

            popular = totpubl * 0.10;
            geral = totpubl * 0.50;
            arquibancada = totpubl * 0.30;
            cadeiras = totpubl * 0.10;

            rdp = 0;
            rdg = 0;
            rdc = 0;
            rda = 0;
            
            if (popular > 0)
            {
                rdp = popular * 5;
            }
            if (geral > 0)
            {
                rdg = geral * 10;
            }
            if (arquibancada > 0)
            {
                rda = arquibancada * 20;
            }
            if (cadeiras > 0)
            {
                rdc = cadeiras * 30;
            }

            rendatot = rdp + rdg + rda + rdc;

            txtRes.Text = rendatot.ToString();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtPubTotal.Clear();
            txtRes.Clear();
            txtPubTotal.Focus().ToString();
        }
    }
}
