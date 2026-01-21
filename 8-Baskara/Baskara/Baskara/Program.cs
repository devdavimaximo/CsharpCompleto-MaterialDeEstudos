namespace Baskara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 29;
            double b = -29;
            double c = 3;

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"As raizes são: {x1} e {x2}");

        }
    }
}
