using System;
using System.Collections.Generic;
using System.Text;
using Products.Entities;

namespace Products.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        override public string PriceTag()
        {
            return $"{Name} (used) $ {Price:F2} (Manufacture date: {ManufactureDate:dd/MM/yyyy})";
        }
    }
}
