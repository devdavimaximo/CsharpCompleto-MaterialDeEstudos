using System.Reflection.Metadata;
using System.Collections.Generic;

namespace lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Nayara"); // Adiciona um nome à lista
            names.Add("Davi");
            names.Add("Nanay");

            names.Insert(0, "Jesus"); // Insere um nome na posição x da lista

            foreach (string obj in names)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"Propriedade count: {names.Count}"); // Propriedade que exibe a quantidade de itens na lista

            Console.WriteLine("---------------------------------");

            string s1 = names.Find(x => x[0] == 'N'); // Encontra o primeiro item que começa com a letra 'N' atravez de uma função LAMBDA
            Console.WriteLine($"First 'N': {s1}");

            string s2 = names.FindLast(x => x[0] == 'N'); // Encontra o último item que começa com a letra 'N' atravez de uma função LAMBDA
            Console.WriteLine($"Last 'N': {s2}");

            Console.WriteLine("---------------------------------");

            int pos1 = names.FindIndex(x => x[0] == 'N');
            Console.WriteLine($"First Position 'N': {pos1}"); // Encontra a posição do primeiro item que começa com a letra 'N'

            int pos2 = names.FindLastIndex(x => x[0] == 'N');
            Console.WriteLine($"Last Position 'N': {pos2}"); // Encontra a posição do último item que começa com a letra 'N'

            Console.WriteLine("---------------------------------");

            List<string> names2 = names.FindAll(x => x.Length == 5); // Cria uma nova lista filtrando os nomes que possuem 5 letras
            foreach (string tal in names2)
            {
                Console.WriteLine(tal);
            }

            Console.WriteLine("---------------------------------");

            names.Remove("Nanay"); // Remove o nome "Nanay" da lista
            foreach (string tal in names)
            {
                Console.WriteLine(tal);
            }

            Console.WriteLine("---------------------------------");

            names.RemoveAll(x => x[0] == 'N'); // Remove todos os nomes que começam com a letra 'N'
            foreach (string tal in names)
            {
                Console.WriteLine(tal);
            }

            Console.WriteLine("---------------------------------");

            names.RemoveAt(1); // Remove o nome na posição 1 da lista
            foreach (string tal in names)
            {
                Console.WriteLine(tal);
            }

            Console.WriteLine("---------------------------------");

            names.RemoveRange(2, 2); // Remove uma faixa de nomes da lista, começando na posição 2 e removendo 2 itens
            foreach (string tal in names)
            {
                Console.WriteLine(tal);
            }
        }
    }
}
