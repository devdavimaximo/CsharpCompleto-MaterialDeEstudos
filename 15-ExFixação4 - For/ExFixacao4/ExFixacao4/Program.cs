namespace ExFixacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int X = int.Parse(Console.ReadLine());
            int impares = 1;

            for (int i = 1; i <= X; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }


            }
        }
    }
}