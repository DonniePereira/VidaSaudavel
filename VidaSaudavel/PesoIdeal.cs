using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VidaSaudavel
{
    public partial class PesoIdeal : Form
    {
        public PesoIdeal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Altura = double.Parse(txtAltura.Text);
                double PesoIdeal;
                string PesoIdealFormat;

                if (cmbSexo.Text == "Feminino")
                {
                    PesoIdeal = (Altura * 62.7) - 44.7;
                    PesoIdealFormat = PesoIdeal.ToString("0.00");                  

                    MessageBox.Show("Seu peso ideal é: " + PesoIdealFormat, "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Masculino")
                {
                    PesoIdeal = (Altura * 72.7) - 58;
                    PesoIdealFormat = PesoIdeal.ToString("0.00");

                    MessageBox.Show("Seu peso ideal é: " + PesoIdealFormat, "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os valores informados", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
