namespace RefVsVslor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

            // Quando alocamos (new) qualquer tipo de estruturado (classe, struct, array), são atribuídos valores padrão aos seus elementos.

            /*
            1 - números: 0
            2 - booleanos: false
            3 - char: caractere código 0 (null)
            4 - objeto: null             
            */
        }
    }
}
