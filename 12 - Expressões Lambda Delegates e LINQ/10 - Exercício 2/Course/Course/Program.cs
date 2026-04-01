using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;
using System.Linq;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee { Name = name, Email = email, Salary = salary });
                    }

                    var emails = list.Where(e => e.Salary > limit).OrderBy(e => e.Email).Select(e => e.Email);
                    var sum = list.Where(e => e.Name.StartsWith("M")).Sum(e => e.Salary);

                    Console.WriteLine("Email of people whose salary is more than " + limit.ToString("F2",CultureInfo.InvariantCulture));
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
