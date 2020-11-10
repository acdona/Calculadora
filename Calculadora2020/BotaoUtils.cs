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
    }
}
