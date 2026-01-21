using System.Threading.Channels;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            // Vetor de string

            /*string s = Console.ReadLine(); // Primeira forma 
            string[] vet = s.Split(' '); // de ler uma string e dividir em várias partes

            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            string[] n = Console.ReadLine().Split(' '); // Segunda forma

            string n1 = n[0];
            string n2 = n[1];
            string n3 = n[2];

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3); */

            //

            // Leitura individual
            int idade = int.Parse(Console.ReadLine());
            char genero = char.Parse(Console.ReadLine());
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string nomeCompleto = Console.ReadLine();

            // Leitura em linha única (vetor)
            string[] dados = Console.ReadLine().Split(' ');

            int idade2 = int.Parse(dados[0]);
            char genero2 = char.Parse(dados[1]);
            double altura2 = double.Parse(dados[2], CultureInfo.InvariantCulture);
            string nome2 = dados[3];

            // Saída dos dados
            Console.WriteLine($"Você digitou a idade: {idade}");
            Console.WriteLine($"Seu gênero é: {genero}");
            Console.WriteLine($"Sua altura é: {altura} cm");
            Console.WriteLine($"Seu nome é: {nomeCompleto}");

            Console.WriteLine("\nDados lidos do vetor:");
            Console.WriteLine($"Nome: {nome2}");
            Console.WriteLine($"Idade: {idade2}");
            Console.WriteLine($"Altura: {altura2}");
            Console.WriteLine($"Gênero: {genero2}");
        }
    }
}
