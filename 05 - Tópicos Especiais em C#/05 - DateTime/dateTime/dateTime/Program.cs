using System.Globalization;

namespace dateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            DateTime d2 = new DateTime(2022, 10, 29);
            DateTime d3 = new DateTime(2022, 10, 29, 11, 30, 00);
            DateTime d4 = DateTime.Today;
            DateTime d5 = DateTime.UtcNow;

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            //

            DateTime n1 = DateTime.Parse("2022-10-29");
            Console.WriteLine(n1);

            DateTime n2 = DateTime.ParseExact("2027-10-29", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(n2);
        }
    }
}
