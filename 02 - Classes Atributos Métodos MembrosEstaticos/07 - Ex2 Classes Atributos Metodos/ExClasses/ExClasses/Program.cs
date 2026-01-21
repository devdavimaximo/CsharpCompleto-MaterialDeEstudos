using System.Globalization;

namespace ExClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"ÁREA = {retangulo.Area()}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro()}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal()}");
        }
    }
}
