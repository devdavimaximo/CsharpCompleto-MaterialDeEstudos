using System;
using System.Globalization;

namespace ExFixacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo; ");
            string name = Console.ReadLine();
            Console.Write("Quantos quartos tem na sua casa? ");
            int rooms = int.Parse(Console.ReadLine());
            Console.Write("Escreva o preço de um produto: ") ;
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');

            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2]);

            Console.WriteLine(name);
            Console.WriteLine(rooms);
            Console.WriteLine(price);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height);
        }
    }
}
