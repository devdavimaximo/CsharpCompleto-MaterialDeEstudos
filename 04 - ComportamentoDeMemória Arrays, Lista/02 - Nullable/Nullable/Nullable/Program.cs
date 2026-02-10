namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // double x = null; // O programa não compila

            Nullable<double> x = null; // ou 
            double? y = null;
            double? z = 29;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(z.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(z.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            } else             {
                Console.WriteLine("x é nulo");
            }

            if (z.HasValue)
            {
                Console.WriteLine(z.Value);
            } else
            {
                Console.WriteLine("z é nulo");
            }
        }
    }
}