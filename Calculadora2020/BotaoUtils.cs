using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2020
{
    public static class BotaoUtils
    {
        public static bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }
        public static string GetFuncao(string funcao)
        {
            string NomeBotao = funcao.ToString();
            if (NomeBotao == "+") { NomeBotao = "Somar"; }
            if (NomeBotao == "-") { NomeBotao = "Subtrair"; }
            if (NomeBotao == "*") { NomeBotao = "Multiplicar"; }
            if (NomeBotao == "/") { NomeBotao = "Dividir"; }
            if (NomeBotao == "." || NomeBotao == ",") { NomeBotao = "Ponto"; }
            if (NomeBotao == "c" || NomeBotao == "C") { NomeBotao = "Limpar"; }
            if (NomeBotao == "=") { NomeBotao = "Igual"; }
            return NomeBotao;
        }
    }
}
