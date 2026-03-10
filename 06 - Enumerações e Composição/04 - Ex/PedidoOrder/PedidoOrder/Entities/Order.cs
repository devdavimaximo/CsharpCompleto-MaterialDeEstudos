using PedidoOrder.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PedidoOrder.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SunTotal();
            }
            return sum;
        }
    }
}
