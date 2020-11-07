﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            lstFita.Items.Add("C " + "---------------- ");
            lstFita.Items.Add("C " + " 0.00");
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
            lstFita.Items.Clear();
            lstFita.Items.Add("----------------");

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        //Clique nos botões de números 0 a 9
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

        //clique no botão dos operadores
        private void btnOperador(object sender, EventArgs e)
        {
            UltimaEntrada = "OPERACAO";
            if (EPrimeiroValor)
            {
                Operador = (sender as Button).Text;
                PrimeiroValor = ValorCorrente;
                //iniciando impressão em fita
                lstFita.Items.Add(ValorCorrente + Operador);
                lstFita.SetSelected(lstFita.Items.Count - 1, true);
                lstFita.SetSelected(lstFita.Items.Count - 1, false);
            }
            else
            {
                if (LimpaTexto)
                {
                    return;
                }
                //segundo comando

                lstFita.Items.Add(ValorCorrente + Operador);
                lstFita.SetSelected(lstFita.Items.Count - 1, true);
                lstFita.SetSelected(lstFita.Items.Count - 1, false);
                Calcular();
                Operador = (sender as Button).Text;
            }
            EPrimeiroValor = false;
            LimpaTexto = true;
            ValorDecimalPresente = false;

        }


        //clique no botão igual
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (UltimaEntrada == "IGUAL")
            {
                Limpar();
            }
            if (!EPrimeiroValor)
            {
                lstFita.Items.Add(txtVisor.Text);
                lstFita.SetSelected(lstFita.Items.Count - 1, true);
                lstFita.SetSelected(lstFita.Items.Count - 1, false);
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
            
            lstFita.Items.Add(txtVisor.Text);
            lstFita.SetSelected(lstFita.Items.Count - 1, true);
            lstFita.SetSelected(lstFita.Items.Count - 1, false);

            UltimaEntrada = "IGUAL";
        }
        //clique no botão ponto 
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
        //clique botão Back Space
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

        //Clique botão CE
        private void btnCE_Click(object sender, EventArgs e)
        {
            ValorCorrente = "0";
            EPrimeiroValor = true;
            txtVisor.Text = "0";
            ValorDecimalPresente = false;
            UltimaEntrada = "CE";
        }

        private void btnLimpaFita_Click(object sender, EventArgs e)
        {
            lstFita.Items.Clear();
        }
    }
}
