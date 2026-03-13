using Course.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Entities
{
    internal class SavingsAccountPlus : SavingsAccount // A classe SavingsAccountPlus não pode herdar de SavingsAccount,
                                                       // pois esta última é selada (sealed).
    {
        public override void Withdraw(double amount) // Não é possível sobrescrever o método Withdraw()
                                                     // da classe SavingsAccount, pois ela é selada (sealed).
        {
        }
    }
}
