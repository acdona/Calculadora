using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2020
{
    public partial class Form1 : Form
    {
        //Variáveis
        decimal Total;
        decimal UltimoNumero;
        string Operador;


        //Método Limpar
        private void Limpar()
        {
            Total = 0;
            UltimoNumero = 0;
            Operador = "+";
            txtVisor.Text = "0";

        }

        //Método Calcular
        private void Calcular()
        {
            switch (Operador)
            {
                case "+":

                    Total += UltimoNumero;
                    break;

                case "-":
                    Total -= UltimoNumero;
                    break;

                case "/":
                    Total /= UltimoNumero;
                    break;

                case "*":
                    Total *= UltimoNumero;
                    break;
                case "%":
                    Total %= UltimoNumero;
                    break;
            }

            UltimoNumero = 0;
            txtVisor.Text = Total.ToString();

        }

        public Form1()
        {
            InitializeComponent();
            Limpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnNumero(object sender, EventArgs e)
        {
            if (UltimoNumero == 0 && txtVisor.Text != "0," && txtVisor.Text != "0,0")
            {
                txtVisor.Text = (sender as Button).Text;
            }
            else
            {

                txtVisor.Text += (sender as Button).Text;
            }

            UltimoNumero = Convert.ToDecimal(txtVisor.Text);


        }

        private void btnOperador(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDecimal(txtVisor.Text);
            Calcular();
            Operador = (sender as Button).Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDecimal(txtVisor.Text);
            Calcular();
            Operador = "+";
            Total = 0;
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
           
            if (txtVisor.Text == "0" || UltimoNumero != 0.0M)
            {
                txtVisor.Text += ",";

            }
            else
            {
                txtVisor.Text = "0,";
            }
           
            UltimoNumero = Convert.ToDecimal(txtVisor.Text);

        }
    }
}
