using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Jeronimu", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Alfreda", 0.0, 500.00);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bobson", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Marleinison", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            
            // BusinessAccount acc5 = (BusinessAccount)acc3; // InvalidCastException
            if (acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount)acc3; dessa forma ou
                BusinessAccount acc5 = acc3 as BusinessAccount; // dessa forma (as)
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
