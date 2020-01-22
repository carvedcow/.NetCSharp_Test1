using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_ChunFeiJohnnyTiu
{
    internal class CancelTransactionLine : iAction
    {
        public double ApplyTransaction(double transactionAmount, double totalAmount)
        {
            return totalAmount;
        }
    }
}
