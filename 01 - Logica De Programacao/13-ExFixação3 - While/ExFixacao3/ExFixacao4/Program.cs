namespace ExFixacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 

            const int senha = 2910;

            Console.Write("Digite Sua Senha: ");
            int number = int.Parse(Console.ReadLine());

            while (number != senha)
            {
                Console.WriteLine("Senha Inválida");
                Console.Write("Digite Sua Senha: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            // Exercício 2 


        }
    }
}
