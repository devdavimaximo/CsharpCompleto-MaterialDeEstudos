using System.Globalization;

namespace ExClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {f.ToString()}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.IncreaseSalary(percentage);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f.ToString()}");
        }
    }
}
