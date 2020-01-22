using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_ChunFeiJohnnyTiu
{
    class UI
    {
        public void ShowMenu()
        {
            Console.WriteLine("Cash Register has started.");
        }

        public double EnterTransactionLine()
        {
            // Properties------------------------------------

            // Transaction Class contains a Product Class.
            Transaction transaction = new Transaction();
            Product product = new Product();
            transaction.product = product;

            double currentAmount;

            // Methods----------------------------------------

            // Get Transaction.Product Price
            Console.Write("\nPlease enter your item's price: ");
            transaction.product.price = double.Parse(Console.ReadLine());

            // Get Transaction Quantity
            Console.Write("Please enter your item's quantity: ");
            transaction.quantity = int.Parse(Console.ReadLine());

            // Combined amount of the transaction
            currentAmount = (transaction.product.price * transaction.quantity);

            return currentAmount;
        }

        public void ShowTransactionLine(string totalType, double amount)
        {
            Console.WriteLine($"The current {totalType} is {amount}$.");
        }
    }
}
