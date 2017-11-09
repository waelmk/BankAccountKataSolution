using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountKata
{
    public class Operation
    {
        public string Refrence { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal NewBalance { get; set; }
        public OperationType Type { get; set; }

        private string OperationTypeName { get { return (Type == OperationType.Credit) ? "Credit" : "Debit"; } }

        public StringBuilder PrintOperation()
        {

            StringBuilder Line = new StringBuilder();

            Line.Append("  ").Append(Refrence);
            Line.Append("  ").Append(OperationTypeName);
            Line.Append("  ").Append(Date.ToShortDateString());
            Line.Append("    ").Append(Amount);
            Line.Append("  ").Append(NewBalance);
            Line.AppendLine();

            return Line;

        }

    }
}
