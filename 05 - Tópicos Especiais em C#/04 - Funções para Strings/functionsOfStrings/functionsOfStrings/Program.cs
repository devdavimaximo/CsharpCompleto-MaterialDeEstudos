namespace functionsOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abcde DEFG   ";

            string n1 = original.ToUpper();
            string n2 = original.ToLower();
            string n3 = original.Trim();

            int y1 = original.IndexOf("de");
            int y2 = original.LastIndexOf("de");

            string n4 = original.Substring(3);
            string n5 = original.Substring(3, 5);

            string n6 = original.Replace('a', 'x');
            string n7 = original.Replace("abc", "xy");

            bool a1 = String.IsNullOrEmpty(original);
            bool a2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original: - {original} -");
            Console.WriteLine($"ToUpper: - {n1} -");
            Console.WriteLine($"ToLower: - {n2} -");
            Console.WriteLine($"Trim: - {n3} -");
            Console.WriteLine($"IndexOf('de'): - {y1} -");
            Console.WriteLine($"LastIndexOf('de'): - {y2} -");
            Console.WriteLine($"Substring(3): - {n4} -");
            Console.WriteLine($"Substring(3, 5): - {n5} -");
            Console.WriteLine($"Replace('a', 'x'): - {n6} -");
            Console.WriteLine($"Replace('abc', 'xy'): - {n7} -");
            Console.WriteLine($"IsNullOrEmpty: - {a1} -");
            Console.WriteLine($"IsNullOrWhiteSpace: - {a2} -");
        }
    }
}
