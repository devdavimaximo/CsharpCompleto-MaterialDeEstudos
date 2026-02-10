namespace RefOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 29;
            Calculator.Triple(ref y);
            Console.WriteLine(y); // reference parameter should be tripled

            int a = 10;
            int triple;
            Calculator.TripleOut(a, out triple);
            Console.WriteLine(triple); // out parameter should be tripled

        }
    }
}
