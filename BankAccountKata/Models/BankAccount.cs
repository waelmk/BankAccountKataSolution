using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountKata
{
    public class BankAccount
    {
        public string AccountId { get; set; }
        public string RIB { get; set; }
        public decimal Balance { get; set; }

        public IList<Operation> Operations { get; set; }

        public BankAccount()
        {
            Operations = new List<Operation>();
            Balance = 0;
        }

        public void Deposit(decimal amount, string reference)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("Can't deposit negativ amout");

            Balance += amount;

            Operations.Add(
                new Operation
                {
                    Amount = amount,
                    Date = DateTime.Now,
                    Type = OperationType.Credit,
                    NewBalance = Balance,
                    Refrence = reference
                });
        }

        public void Withdraw(decimal amount, string reference)
        {
            if (amount > Balance)
            {
                throw new Exception("Insufficient balance !");
            }

            Balance -= amount;

            Operations.Add(
               new Operation
               {
                   Amount = amount,
                   Date = DateTime.Now,
                   Type = OperationType.Debit,
                   NewBalance = Balance,
                   Refrence = reference
               });
        }

        public StringBuilder PrintStatement(DateTime? dateMin)
        {
            StringBuilder AccountHistory = new StringBuilder();

            AccountHistory.Append(" Reference   Type     Date    Amount   Balance");
            AccountHistory.AppendLine();

            IList<Operation> OrderedOperations = Operations.Where(x => x.Date >= dateMin).OrderBy(x => x.Date).ToList();

            foreach (var item in OrderedOperations)
            {
                AccountHistory.Append(item.PrintOperation());
            }

            return AccountHistory;
        }

    }
}