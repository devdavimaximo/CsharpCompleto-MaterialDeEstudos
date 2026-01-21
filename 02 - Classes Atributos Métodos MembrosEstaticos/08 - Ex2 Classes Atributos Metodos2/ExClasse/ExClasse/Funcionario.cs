using System;
using System.Collections.Generic;
using System.Text;

namespace ExClasse
{
    internal class Funcionario
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public override string ToString()
        {
            return Name + ", $"
                + NetSalary();
        }
        public double NetSalary()
        {
            return GrossSalary - Tax;
        }
        public void IncreaseSalary(double percentage)
        {
            GrossSalary += GrossSalary * percentage / 100.0;
        }
    }
}
