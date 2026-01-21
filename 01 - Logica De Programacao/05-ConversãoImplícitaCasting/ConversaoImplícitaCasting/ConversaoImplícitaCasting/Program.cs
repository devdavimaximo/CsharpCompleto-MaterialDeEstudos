using System;

namespace ImplicitoCsting;

class Program
{
    static void Main(string[] args)
    {

        float n = 4.5f;
        double y = n;

        double a = 5.5;
        float b = (float)a;

        int c = (int)a; // Casting explícito


        Console.WriteLine(b);
        Console.WriteLine(c);

        int x = 5;
        int z = 2;

        double resultado = (double) x / z; // Casting explícito para evitar divisão inteira

        Console.WriteLine(resultado);

    }
}