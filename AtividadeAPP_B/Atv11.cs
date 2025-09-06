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
    public partial class Atv11 : Form
    {
        public Atv11()
        {
            InitializeComponent();
        }

        private void Atv11_Load(object sender, EventArgs e)
        {

        }

        private void lblHotdog_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double altura, peso, IMC, arredondado;
            string classe;

                altura = Convert.ToDouble(txtAltura.Text);
                peso = Convert.ToDouble(txtPeso.Text);

            IMC = peso / (altura * altura);
            classe = "";

            if (IMC < 17)
            {
                classe = "Magreza severa";
            }
            else if (IMC >= 17 & IMC < 18.5)
            {
                classe = "Magreza leve";
            }
            else if (IMC >= 18.5 & IMC < 25)
            {
                classe = "Peso normal";
            }
            else if (IMC >= 25 & IMC < 30)
            {
                classe = "Sobrepeso";
            }
            else if (IMC >= 30 & IMC < 35)
            {
                classe = "Obesidade classe I";
            }
            else if (IMC >= 35 & IMC < 40)
            {
                classe = "Obesidade classe II";
            }
            else if (IMC > 40)
            {
                classe = "Obesidade classe III";
            }

            arredondado = Math.Round(IMC, 1);

            txtIMC.Text = arredondado.ToString();
            txtClasse.Text = classe.ToString();

            // Não sei se nesse exercicio deveria ter sido usado switch case, mas na versão do meu c# diz que ( <, >, <= e >=) não podem ser usados no swith case

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtClasse.Clear();
            txtIMC.Clear();
            txtAltura.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
