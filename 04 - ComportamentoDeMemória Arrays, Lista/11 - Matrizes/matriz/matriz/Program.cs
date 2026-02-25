namespace matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[3, 4];

            Console.WriteLine(mat.Length); // Total number of elements in the matrix

            Console.WriteLine(mat.Rank); // Number of dimensions in the matrix (2 for a 2D array)

            Console.WriteLine(mat.GetLength(0)); // Number of rows (first dimension)

            Console.WriteLine(mat.GetLength(1)); // Number of columns (second dimension)
        }
    }
}
