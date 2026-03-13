using System;
using System.Collections.Generic;
using System.Text;
using Products.Entities;

namespace Products.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        override public string PriceTag()
        {
            return $"{Name} $ {TotalPrice():F2} (Customs fee: $ {CustomsFee:F2})";
        }
    }
}
