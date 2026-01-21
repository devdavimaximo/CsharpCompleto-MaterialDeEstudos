using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double Converter(double cotacao, double quantidade)
        {
            return quantidade * cotacao * (1.0 + Iof);
        }
    }
}
