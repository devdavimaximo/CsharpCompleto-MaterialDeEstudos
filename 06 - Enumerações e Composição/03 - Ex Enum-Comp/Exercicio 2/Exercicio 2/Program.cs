using System;
using Exercicio_2.Entities;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("The best retiro");
            Comment c2 = new Comment("THE BEST");
            Post p1 = new Post(
                DateTime.Parse("29/10/2022 13:05:44"),
                "Retiro Oxigênio 2022",
                "Melhor retiro de todos os tempos",
                2910
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Casamento NayVi");
            Comment c4 = new Comment("Será");
            Post p3 = new Post(
                DateTime.Parse("29/10/2027 19:00:00"),
                "Casamento NayVi",
                "A melhor escolha",
                2910
                );
            p3.AddComment(c3);
            p3.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p3);
        }
    }
}
