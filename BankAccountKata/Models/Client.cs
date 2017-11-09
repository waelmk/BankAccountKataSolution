using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountKata
{
    public class Client
    {
        public decimal ID { get; set; }
        public decimal FisrtName { get; set; }
        public decimal LastName { get; set; }

        public IList<BankAccount> BankAccounts { get; set; }
    }
}
