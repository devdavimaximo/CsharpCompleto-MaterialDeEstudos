using System;
using System.Globalization;

namespace SaidaDeDados
{
    class
        Program
    {
        static void Main(string[] args)
        {

            char genero = 'F';
            int idade = 29;
            double saldo = 10.29102022;
            string nome = "Nayara";

            /* Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); */

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); // placeholders
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); // interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais"); // concatenação

        }
    }
}
