using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "Nayara";
            //string b = "Isabelly";

            //Console.WriteLine(a.Equals(b));

            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());

            Client a = new Client { Name = "Nayara", Email = "nayararodriguesgirardi@gmail.com" };
            Client b = new Client { Name = "Davi", Email = "davimaximoquoos@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
