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
    public partial class Atv10 : Form
    {
        public Atv10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome;
            char sexo;
            double idade, acresc, salario, salarfinal;

            nome = Convert.ToString(txtNome.Text);
            sexo = Convert.ToChar(txtSexo.Text);
            idade = Convert.ToDouble(txtIdade.Text);
            salario = Convert.ToDouble(txtSalario.Text);

            acresc = 0;

            if (sexo == 'M' & idade >= 30)
            {
                acresc = 100;
            }
            else if (sexo == 'M' & idade < 30)
            {
                acresc = 50;
            } 
            else if (sexo == 'F' & idade >= 30)
            {
                acresc = 250;
            }
            else if (sexo == 'F' & idade < 30 )
            {
                acresc = 150;
            }

            salarfinal = salario + acresc;
            txtres.Text = Convert.ToString(salarfinal);
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtSexo.Clear();
            txtSalario.Clear();
            txtNome.Clear();
            txtNome.Focus();
                
             
        }
    }
}