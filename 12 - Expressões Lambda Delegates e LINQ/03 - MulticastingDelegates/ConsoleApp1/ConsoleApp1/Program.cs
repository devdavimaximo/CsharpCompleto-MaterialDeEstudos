using ConsoleApp1.Entities;

namespace ConsoleApp1
{

    delegate void BinaryNumericOperation(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 29;
            double b = 10;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}
