using System.Globalization;

namespace ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20) ? desconto = preco * 0.1 : desconto = preco * 0.05;

            Console.WriteLine(desconto);
        }
    }
}
