using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller.Entity_Layer
{
    public enum TransactionTypes
    {
        CheckBalance,
        Deposit,
        Withdraw,
        ViewTransactions,
        Exit
    }
}
