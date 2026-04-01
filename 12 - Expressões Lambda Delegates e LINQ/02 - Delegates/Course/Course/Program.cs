using Course.Services;

namespace Course
{

    delegate double BinaryNumericOperation(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double resultBinary = op(a, b);
            double result = CalculationService.Sum(a, b);

            Console.WriteLine(resultBinary);
            Console.WriteLine(result);       
        }
    }
}
