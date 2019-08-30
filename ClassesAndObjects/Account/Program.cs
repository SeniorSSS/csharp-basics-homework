using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", (decimal)100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", (decimal)1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            
            bartosAccount.withdrawal(20);
            Console.WriteLine("Barto's account balance is now: "+bartosAccount.balance());
            bartosSwissAccount.deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: "+bartosSwissAccount.balance());
            

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            Console.WriteLine("------------");


            var metAccount = new Account("Mats account", (decimal)100.00);
            var myAccount = new Account("My aacount", 0);
            var money = metAccount.withdrawal(100);

            myAccount.deposit(money);

            Console.WriteLine(myAccount.ToString());

            Console.WriteLine("-----------------------");

            var A = new Account("A",100);
            var B = new Account("B", 0);
            var C = new Account("C",0);

            Transfer(A,B,50);
            Transfer(B,C,25);

            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());



            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal((decimal)howMuch));
        }

    }
}
