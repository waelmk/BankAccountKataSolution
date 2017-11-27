using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount
            {
                AccountId = "45000",
                Balance = 1000
            };

            acc1.Deposit(100, "000001d");
            acc1.Withdraw(500, "000001w");

            acc1.Deposit(800, "000002d");

            Console.Write(acc1.PrintStatement(new DateTime(2017, 11, 2)));

            Console.ReadLine();

            
        }
    }
}
