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
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Peso = double.Parse(txtPeso.Text);
                double Altura = double.Parse(txtAltura.Text);

                double CalcIMC = Peso / Math.Pow(Altura, 2);
                string IMCformat = CalcIMC.ToString("0.00");

                if (CalcIMC < 18.5)
                {
                    MessageBox.Show("Seu IMC é de: " + IMCformat + " Você está abaixo do peso", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CalcIMC >= 18.5 && CalcIMC <= 24.9)
                {
                    MessageBox.Show("Seu IMC é de: " + IMCformat + " Você tem um peso normal", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CalcIMC >= 25 && CalcIMC <= 29.9)
                {
                    MessageBox.Show("Seu IMC é de: " + IMCformat + " Você está com sobrepeso", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (CalcIMC >= 30 && CalcIMC <= 34.9)
                {
                    MessageBox.Show("Seu IMC é de: " + IMCformat + " Você tem obesidade de grau 1", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CalcIMC >= 35 && CalcIMC <= 39.9)
                {
                    MessageBox.Show("Seu IMC é de: " + IMCformat + " Você tem obesidade de grau 2", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (CalcIMC <= 40)
                {
                    MessageBox.Show("Seu IMC é de: " + IMCformat + " Você tem obesidade de grau 3", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os valores informados", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
