using System.Linq;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the query and display the results
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
        }
    }
}
