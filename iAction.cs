using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_ChunFeiJohnnyTiu
{
    internal interface iAction
    {
        double ApplyTransaction(double transactionAmount, double totalAmount);
    }
}
