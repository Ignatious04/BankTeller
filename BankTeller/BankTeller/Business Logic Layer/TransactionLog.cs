using BankTeller.Entity_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller.Business_Logic_Layer
{
    public static class TransactionLog
    {
        public static List<TransactionEntity> TransactionLogs { get; set; } = new List<TransactionEntity>();
    }
}
