namespace ExClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Age = int.Parse(Console.ReadLine());

            if (pessoa1.Age > pessoa2.Age)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.Name}");
            } else if (pessoa1.Age < pessoa2.Age)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoa2.Name}");
            } else
            {
                Console.WriteLine("Ambos tem a mesma idade");
            }

        }
    }
}
