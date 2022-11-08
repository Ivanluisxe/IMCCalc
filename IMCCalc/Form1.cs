using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double imc, altura, peso;

            try
            {
                altura = double.Parse(txbAltura.Text);
                peso = double.Parse(txbPeso.Text);

                if (altura == 0)
                {
                    imc = 0;
                    lblResultText.Text = "Erro, tente novamente";
                }
                else
                {
                    imc = peso / (altura * altura);
                    imc = Math.Round(imc, 2);
                    txbResultadoImc.Text = imc.ToString();

                }

                if (imc <= 18.5)
                {
                    lblResultText.Text = "Abaixo do peso!";
                    lblResultText.ForeColor = Color.Blue;
                }
                else if (imc > 18.5 && imc < 24.9)
                {
                    lblResultText.Text = "Peso ideal.";
                    lblResultText.ForeColor = Color.LightGreen;
                }
                else if (imc > 24.9 && imc < 29.9)
                {
                    lblResultText.Text = "Levemente acima do peso.";
                    lblResultText.ForeColor = Color.Green;
                }
                else if (imc > 29.9 && imc < 34.9)
                {
                    lblResultText.Text = "Obesidade grau 1.";
                    lblResultText.ForeColor = Color.Red;
                }
                else if (imc > 34.9 && imc < 39.9)
                {
                    lblResultText.Text = "Obesidade grau 2 (Severa).";
                    lblResultText.ForeColor = Color.Red;
                }
                else if (imc > 39.9)
                {
                    lblResultText.Text = "Obesidade grau 3 (Morbida).";
                    lblResultText.ForeColor = Color.DarkViolet;
                }
                if (imc == 0)
                {
                    lblResultText.Text = "Erro, altura não pode ser 0";
                    lblResultText.ForeColor = Color.Blue;
                }
            }
            catch
            {
                lblResultText.Text = "Erro, tente novamente!";
                lblResultText.ForeColor = Color.Red;
            }
            

            

        }



    }

        

        
    
}
