using System;
using System.Linq;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> p = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = p
                .Where(x => x.Category.Tier == 1 && x.Price < 900.0);
            Print("TIER 1 AND THE PRICE < 900:", r1);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            var r2 = p
                .Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Print("NAMES OF PRODUCTS FROM TIER 1:", r2);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            var r3 = p
                .Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            var r4 = p
                .Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4:", r5);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            var r6 = p.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);
            var r7 = p.Where(x => x.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            var r8 = p.Where(x => x.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or defaul test1: " + r8);
            var r9 = p.Where(x => x.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or defaul test2: " + r9);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            var r10 = p.Max(x => x.Price);
            Console.WriteLine("Max price: " + r10);
            var r11 = p.Min(x => x.Price);
            Console.WriteLine("Min price: " + r11);
            var r12 = p.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            Console.WriteLine("Category 1 Sum prices: " + 12);
            var r13 = p.Where(x => x.Category.Id == 1).Average(x => x.Price);
            Console.WriteLine("Category 1 Avarege prices: " + r13);
            var r14 = p.Where(x => x.Category.Id == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Avarege prices: " + r14);
            var r15 = p.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 5 Aggregate sum: " + r15);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
            var r16 = p.GroupBy(x => x.Category);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product obj in group)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }
        }
    }
}
