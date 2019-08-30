using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var benben = new Account("Benson", 17.5);
            var benben2 = new Account("Benson", -17.25);
            benben.ShowUserNameAndBalance();
            benben2.ShowUserNameAndBalance();

            Console.ReadKey();
        }
    }
}
