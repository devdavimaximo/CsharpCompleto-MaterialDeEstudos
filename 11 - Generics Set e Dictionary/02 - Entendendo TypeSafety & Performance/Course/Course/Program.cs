namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> ps = new PrintService<int>();
            Console.Write("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ps.AddValue(x);
            }

            ps.Print();
            Console.Write($"First: {ps.First()}");
        }
    }
}
