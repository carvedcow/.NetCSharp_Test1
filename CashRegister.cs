using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_ChunFeiJohnnyTiu
{
    class CashRegister
    {
        // Properties------------------------------------

        public double totalTransaction { get; set; }
        public double totalAmount { get; set; }

        // Constructors
        public CashRegister(double startAmount) 
        {
            totalAmount = startAmount;
        }

        // Methods----------------------------------------

        public bool CloseRegister() 
        {
            Console.Write("\nClose the register for the day? (Y/N)");
            var contKey2 = Console.ReadKey();
            return (contKey2.Key == ConsoleKey.Y ? false : true);
        }

        public double DoTransActionLine(double transactionAmount)
        {
            // Properties------------------------------------

            iAction action = new AddTransactionLine();

            // Methods----------------------------------------

            // Get Transaction Type
            Console.Write("Please choose your transaction type: (1=add, 2=remove, 3=cancel) ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    action = new AddTransactionLine();
                    break;
                case 2:
                    action = new DeleteTransactionLine();
                    break;
                case 3:
                    action = new CancelTransactionLine();
                    break;
            }
            // Return the value after transaction is performed.
            return action.ApplyTransaction(transactionAmount, totalAmount);

        }
    }
}
