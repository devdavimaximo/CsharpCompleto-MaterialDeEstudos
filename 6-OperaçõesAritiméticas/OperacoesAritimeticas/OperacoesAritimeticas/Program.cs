using System;

namespace OperadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.0;
            double b = -3.0;
            double c = 1.0;

            double delta = Math.Pow(b, 2) - 4 * a * c; 

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"As raízes da equação são: {x1} e {x2}");
        }
    }
}