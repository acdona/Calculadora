using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora2020
{
    public partial class Form1 : Form
    {
        //Variáveis
        private string CasasDecimais;
        private string PrimeiroValor;
        private string UltimaEntrada;
        private string ValorCorrente;
        private string Operador;
        private string SeletorDecimais; //0 = 0; 1 = 2 ; F= Vários
        private string FormataSaida;
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

                case "%":
                    NumeroSaida = (Convert.ToDouble(PrimeiroValor) % Convert.ToDouble(ValorCorrente)).ToString();
                    break;



            }
            PrimeiroValor = NumeroSaida;
            ValorCorrente = NumeroSaida;
            EPrimeiroValor = true;
            txtVisor.Text = NumeroSaida;
            Operador = "=";
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
            if (tkbDigitos.Value == 0)
            {
                lstFita.Items.Add("C " + " 0");
            }
            else if (tkbDigitos.Value == 1)
            {
                lstFita.Items.Add("C " + " 0.00");
            }
            else
            {
                lstFita.Items.Add("C " + " 0.00000000");
            }

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
            this.KeyPreview = true;
            lstFita.Items.Clear();
            lstFita.Items.Add("----------------");
            SeletorDecimais = "2";
            CasasDecimais = SeletorDecimais;
            tkbDigitos.Select();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        //Clique nos botões de números 0 a 9
        private void btnNumero(object sender, EventArgs e)
        {
            if (txtVisor.TextLength != 25)
            {
                if (UltimaEntrada == "IGUAL")
                {
                    LimpaTexto = true;
                    EPrimeiroValor = true;
                    ValorDecimalPresente = false;
                }

                if (UltimaEntrada == "VIRGULA")
                {
                    //se  o tamanho dos digitos for maior que CasasDecimais pular
                    //implementar
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
                ImprimimeFita();
            }
            else
            {
                if (LimpaTexto)
                {
                    return;
                }
                //segundo comando
                ImprimimeFita();
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
                ImprimimeFita();
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
            try
            {
                ImprimimeFita();
            }
            catch (Exception)
            {
                txtVisor.Text = "";//"""***ERRO Divisão por zero***";
            }
            finally
            {
                LimpaTexto = false;
            }
            UltimaEntrada = "IGUAL";
        }
        //clique no botão ponto 
        private void btnPonto_Click(object sender, EventArgs e)
        {

            if (txtVisor.TextLength != 25)
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

        //Clique botão limpa fita
        private void btnLimpaFita_Click(object sender, EventArgs e)
        {
            lstFita.Items.Clear();
        }

        //escolha no seletor de dígitos
        private void tkbDigitos_Scroll(object sender, EventArgs e)
        {
            if (tkbDigitos.Value == 0)
            {
                SeletorDecimais = "0";
            }
            else if (tkbDigitos.Value == 1)
            {
                SeletorDecimais = "2";
            }
            else { SeletorDecimais = "8"; }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToDouble(e.KeyChar.ToString()) >= 0 && Convert.ToDouble(e.KeyChar.ToString()) <= 9)
                {
                    Button btn = this.Controls.OfType<Button>().ToList().FirstOrDefault(b => b.Name == "btn" + e.KeyChar.ToString());
                    btn.PerformClick();
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                string NomeBotao = e.KeyChar.ToString();
                if (NomeBotao == "+") { NomeBotao = "Somar"; }
                if (NomeBotao == "-") { NomeBotao = "Subtrair"; }
                if (NomeBotao == "*") { NomeBotao = "Multiplicar"; }
                if (NomeBotao == "/") { NomeBotao = "Dividir"; }
                if (NomeBotao == "." || NomeBotao == ",") { NomeBotao = "Ponto"; }
                if(NomeBotao =="c" || NomeBotao =="C") { NomeBotao = "Limpar"; }
                int Tecla = e.KeyChar.GetHashCode();
                if (Tecla == 851981) { NomeBotao = "Igual"; }
                if (Tecla == 524296) { NomeBotao = "BS"; }
                if (Tecla == 1769499) { NomeBotao = "CE"; }
                Button btn = this.Controls.OfType<Button>().ToList().FirstOrDefault(b => b.Name == "btn" + NomeBotao);
                if (btn == null) { return; }
                btn.PerformClick();
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = Convert.ToString(e.KeyValue);
            if (e.KeyCode == Keys.Delete)
            {
                btnLimpar.PerformClick();
                e.Handled = true;
            }

        }

        private void ImprimimeFita()
        {
            FormataSaida = (double.Parse(txtVisor.Text).ToString("F" + SeletorDecimais.ToString()));
            lstFita.Items.Add(Operador + " " + FormataSaida);
            lstFita.SetSelected(lstFita.Items.Count - 1, true);
            lstFita.SetSelected(lstFita.Items.Count - 1, false);
            txtVisor.Text = FormataSaida;
        }
    }
}
