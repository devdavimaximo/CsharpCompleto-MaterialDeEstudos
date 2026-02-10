using System;

namespace ExVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rooms[] rooms = new Rooms[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());

                rooms[roomNumber] = new Rooms
                {
                    Name = name,
                    Email = email
                };
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
                }
            }
        }
    }
}
