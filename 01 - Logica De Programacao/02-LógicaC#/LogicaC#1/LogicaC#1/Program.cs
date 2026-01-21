using System;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tipos de dados numéricos em C#

            byte n1 = 109; // Até 255
            int n2 = 1029;
            int n3 = 2147483647; // Até 2.147.483.647
            long n4 = 2147483648L; // Até 9.223.372.036.854.775.807
            float n5 = 7.5f; // Sufixo 'f' para float
            double n6 = 7.5; // Número decimal padrão (double)

            // Outros tipos de dados

            bool completo = false; //booleano (true ou false)
            char genero = 'F'; //caractere (aspas simples)
            char letra = '\u004e'; // Unicode para 'N'
            string name = "Nayara"; //string (aspas duplas)
            object obj1 = "Guitarra"; //objeto (pode armazenar qualquer tipo)
            object obj2 = 7.5f;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(name);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
        }
    }
}
