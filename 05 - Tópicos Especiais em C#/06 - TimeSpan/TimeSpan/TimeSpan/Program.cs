namespace timespan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(1, 2, 3); // 1 hour, 2 minutes, 3 seconds
            Console.WriteLine(t1);

            TimeSpan t2 = TimeSpan.FromMinutes(90); // 1 hour, 30 minutes
            Console.WriteLine(t2);
        }
    }
}
