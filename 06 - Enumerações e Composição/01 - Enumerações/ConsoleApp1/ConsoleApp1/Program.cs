using ConsoleApp1.Entities; // Importa o namespace onde a classe Order está definida
using ConsoleApp1.Entities.Enums; // Importa o namespace onde o enum OrderStatus está definido

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            OrderStatus ny = Enum.Parse<OrderStatus>("Delivered"); // Converte a string "Delivered" para o valor correspondente do enum OrderStatus
            string txt = OrderStatus.PendingPayment.ToString(); // Converte o valor do enum para string
            
            Console.WriteLine(ny);
            Console.WriteLine(txt);
        }
    }
}
