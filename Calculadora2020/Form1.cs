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
        private string PrimeiroValor;
        private string UltimaEntrada;
        private string ValorCorrente;
        private string Operador;
        private bool LimpaTexto;
        private bool EPrimeiroValor;
        private bool ValorDecimalPresente;

        //Método Calcular()
        private void Calcular()
        {
            string NumeroSaida = "";
            switch (Operador)
            {
                case "+":

                    NumeroSaida = (Convert.ToDouble(PrimeiroValor) + Convert.ToDouble(ValorCorrente)).ToString();
                    break;

                case "-":
                    NumeroSaida = (Convert.ToDouble(PrimeiroValor) - Convert.ToDouble(ValorCorrente)).ToString();
                    break;

                case "/":
                    if (ValorCorrente == "0")
                    {
                        txtVisor.Text = "***Não pode dividir por zero***";
                        return;
                    }
                    NumeroSaida = (Convert.ToDouble(PrimeiroValor) / Convert.ToDouble(ValorCorrente)).ToString();
                    break;

                case "*":
                    NumeroSaida = (Convert.ToDouble(PrimeiroValor) * Convert.ToDouble(ValorCorrente)).ToString();
                    break;

            }

            Operador = "=";
            EPrimeiroValor = true;
            txtVisor.Text = NumeroSaida;
            PrimeiroValor = NumeroSaida;
            ValorCorrente = NumeroSaida;
        }

        //Limpar
        private void Limpar()
        {
            PrimeiroValor = "0";
            ValorCorrente = "0";
            EPrimeiroValor = true;
            txtVisor.Text = "0";
            ValorDecimalPresente = false;
            UltimaEntrada = "CLEAR";
        }

        private void MostraNumero()
        {

            try
            {
                ValorCorrente = txtVisor.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                LimpaTexto = false;
            }


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
            if (UltimaEntrada == "IGUAL")
            {
                LimpaTexto = true;
                EPrimeiroValor = true;
                ValorDecimalPresente = false;
            }

            if (UltimaEntrada == "VIRGULA")
            {
                txtVisor.Text += (sender as Button).Text;
            }
            else
            {
                if (LimpaTexto)
                {
                    txtVisor.Text = "";

                }
                if (txtVisor.Text != "0")
                {
                    txtVisor.Text += (sender as Button).Text;
                }
                else
                {
                    txtVisor.Text = (sender as Button).Text;
                }
            }
            MostraNumero();
            UltimaEntrada = "NUMERO";
        }

        private void btnOperador(object sender, EventArgs e)
        {
            UltimaEntrada = "OPERACAO";
            if (EPrimeiroValor)
            {
                Operador = (sender as Button).Text;
                PrimeiroValor = ValorCorrente;
            }
            else
            {
                if (LimpaTexto)
                {
                    return;
                }
                Calcular();
                Operador = (sender as Button).Text;
            }
            EPrimeiroValor = false;
            LimpaTexto = true;
            ValorDecimalPresente = false;

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (UltimaEntrada == "IGUAL")
            {
                Limpar();
            }
            if (!EPrimeiroValor)
            {

            }
            if (LimpaTexto)
            {
                return;
            }
            if (Operador == "=")
            {
                UltimaEntrada = "IGUAL";
                return;
            }
            Calcular();

        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (ValorDecimalPresente)
            { return; }

            if (UltimaEntrada == "OPERACAO" || UltimaEntrada == "IGUAL")
            {
                txtVisor.Text = "0,";
                UltimaEntrada = "VIRGULA";
                ValorDecimalPresente = true;
            }
            if (txtVisor.Text == "0" && !(ValorDecimalPresente))
            {
                txtVisor.Text = "0,";
                UltimaEntrada = "VIRGULA";
                ValorDecimalPresente = true;
            }
            else if (!(ValorDecimalPresente))
            {
                txtVisor.Text += ",";
                ValorDecimalPresente = true;
                UltimaEntrada = "VIRGULA";
            }


        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (UltimaEntrada == "OPERACAO" || UltimaEntrada == "IGUAL")
            {
                txtVisor.Text = "0";
                UltimaEntrada = "NUMERO";

            }
            if (txtVisor.TextLength == 1)
            {
                txtVisor.Text = "0";
                ValorDecimalPresente = false;

            }
            else if (txtVisor.TextLength > 0)
            {
                txtVisor.Text = txtVisor.Text.Remove(txtVisor.TextLength - 1, 1);
                if (txtVisor.Text.IndexOf(",") == -1)
                {
                    ValorDecimalPresente = false;
                }
                else if (txtVisor.Text == "0")
                {
                    ValorDecimalPresente = false;
                }
            }


        }
    }
}
