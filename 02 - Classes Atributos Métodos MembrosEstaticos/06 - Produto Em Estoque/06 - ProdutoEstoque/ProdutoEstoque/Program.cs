using System.Reflection.Metadata;   
using System.Globalization;

namespace ProdutoEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto product1 = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            product1.Name = Console.ReadLine();
            Console.Write("Preço: ");
            product1.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            product1.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados do Produto: {product1}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionado em estoque: ");
            int qte = int.Parse(Console.ReadLine());
            product1.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {product1}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            product1.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {product1}");

        }
    }
}
