using BankTeller.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller.Business_Logic_Layer
{
    public class Computation
    {
        public void Deposit(decimal depositAmount)
        {
            AccountEntity.Balance += depositAmount;
            TransactionEntity transactionEntity = new TransactionEntity();
            transactionEntity.TimeStamp = DateTime.Now;
            transactionEntity.TransactionType = TransactionTypes.Deposit;
            transactionEntity.Amount = depositAmount;
            TransactionLog.TransactionLogs.Add(transactionEntity);
        }

        public void Withdraw(decimal withdrawAmount)
        {
            AccountEntity.Balance -= withdrawAmount;
            TransactionEntity transactionEntity = new TransactionEntity();
            transactionEntity.TimeStamp = DateTime.Now;
            transactionEntity.TransactionType = TransactionTypes.Withdraw;
            transactionEntity.Amount = withdrawAmount;
            TransactionLog.TransactionLogs.Add(transactionEntity);
        }
    }
}
