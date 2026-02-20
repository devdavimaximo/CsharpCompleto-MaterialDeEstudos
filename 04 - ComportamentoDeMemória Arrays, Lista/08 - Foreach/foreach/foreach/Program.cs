namespace Studyforeach;

internal class Program
{
    static void Main(string[] args)
    {
        string[] vect = new string[] { "Nayara", "Davi", "Jesus" };
        foreach (string name in vect)
        {
            Console.WriteLine(name);
        }
    }
}
