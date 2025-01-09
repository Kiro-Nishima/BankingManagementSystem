using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class TransactionList
    {
        private static TransactionList instance;
        public Queue<TransactionDetail> transactions = new Queue<TransactionDetail>();

        private TransactionList()
        {

        }

        public static TransactionList GetInstance()
        {
            if(instance == null)
            {
                instance = new TransactionList();
            }

            return instance;
        }
    }
}
