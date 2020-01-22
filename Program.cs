using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister_ChunFeiJohnnyTiu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Properties------------------------------------

            bool sessionContinue = true;
            bool transactionContinue;
            UI ui = new UI();
            double currentTransactionAmount = 0;

            //The Register starts the shift with 200$
            CashRegister cr = new CashRegister(200);

            // Methods----------------------------------------

            while (sessionContinue) 
            {
                // transactionContinue reset
                transactionContinue = true;

                // Clear Console
                Console.Clear();

                // User Interface Initialization
                ui.ShowMenu();

                // Display current total amount
                ui.ShowTransactionLine("total amount inside this register now", cr.totalAmount);

                while (transactionContinue) 
                {
                    // Get Transaction Amount(Price * Quantity), returns current amount
                    currentTransactionAmount = ui.EnterTransactionLine();

                    // Get and Do Transaction;
                    cr.totalAmount = cr.DoTransActionLine(currentTransactionAmount);

                    // Display current total amount
                    ui.ShowTransactionLine("total amount inside this register now", cr.totalAmount);

                    // Add another item?
                    Console.Write("Add another item? (Y/N)");
                    var contKey1 = Console.ReadKey();
                    transactionContinue = (contKey1.Key == ConsoleKey.Y ? true : false);
                }

                // Close Register?
                sessionContinue = cr.CloseRegister();
                Console.Write("\nThank you for using this Register.\nPress any key to exit.");
                Console.ReadKey();

            }
        }
    }
}
