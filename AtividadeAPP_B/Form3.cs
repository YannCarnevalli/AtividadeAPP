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
    public partial class Atv3: Form
    {
        public Atv3()
        {
            InitializeComponent();
        }

        private void Atv3_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double real, dolar, resultado;
            real = Convert.ToDouble(txtreal.Text);
            dolar = Convert.ToDouble(txtdolar.Text);

            resultado = real / dolar;

            

        }
    }
}
