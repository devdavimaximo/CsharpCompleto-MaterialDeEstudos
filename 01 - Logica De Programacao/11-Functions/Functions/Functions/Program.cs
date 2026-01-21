using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int resultado = Maior(num1, num2, num3);

            Console.WriteLine($"O maior número é: {resultado}");
        }

        static int Maior(int a, int b, int c)
        {
            int m;

            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }

            return m;
        }
    }
}
