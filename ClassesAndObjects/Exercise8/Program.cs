using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            decimal startMoney = Decimal.Parse(Console.ReadLine());
            Console.Write("Enter the annual interest rate: ");
            int interest = Int32.Parse(Console.ReadLine());
            var account = new SavingsAccount(interest, startMoney);
            Console.Write("How long has the account been opened? ");
            int months = Int32.Parse(Console.ReadLine());

            for (var i = 0; i < months; i++)
            {
                Console.Write($"Enter amount deposited for month {i+1}: ");
                int deposited = Int32.Parse(Console.ReadLine());
                Console.Write($"Enter amount withdrawn for {i+1}: ");
                decimal withDrawn = Decimal.Parse(Console.ReadLine());
                
                account.deposit(deposited);
                account.withDrawal(withDrawn);
                account.interest();
            }

            account.totalDeposited();
            account.totalWithDrawn();
            account.totalInterest();
            Console.WriteLine($"Ending balance: {account.balance():C2}");

            Console.ReadKey();
        }
    }
}
