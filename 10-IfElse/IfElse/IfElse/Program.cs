using System;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");

            }
        }
    }

}