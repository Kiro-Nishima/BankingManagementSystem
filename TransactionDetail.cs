using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class TransactionDetail
    {
        public int id { get; set; }
        public string type { get; set; }
        public string accountId { get; set; }
        public double amount { get; set; }
        public DateTime date { get; set; }

        public TransactionDetail(int id, string type, string accountId, double amount, DateTime date)
        {
            this.id = id;
            this.type = type;
            this.accountId = accountId;
            this.amount = amount;
            this.date = date;
        }
    }
}
