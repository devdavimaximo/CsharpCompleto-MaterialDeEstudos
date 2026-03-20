using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
