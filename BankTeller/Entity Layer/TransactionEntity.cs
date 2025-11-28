using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller.Entity_Layer
{
    public class TransactionEntity
    {
        public DateTime TimeStamp { get; set; }

        public TransactionTypes TransactionType { get; set; }

        public decimal Amount { get; set; }
    }
}
