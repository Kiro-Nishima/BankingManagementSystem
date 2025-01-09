using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class CustomerAccount
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int accountId { get; set; }
        public string accountType { get; set; }
        public string dateOpened { get; set; }
        public TransactionDetail[] transactons = new TransactionDetail[5];
        public bool limitReached = false;

        public CustomerAccount(int accountId, string email, string name, string phoneNumber, string address, string accountType, string dateOpened)
        {
            this.accountId = accountId;
            this.email = email;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.accountType = accountType;
            this.dateOpened = dateOpened;
        }

        // Add transaction to this account
        public void addNewTransaction(TransactionDetail transactionDetail)
        {
            limitReached = transactons.All(x => x != null);
            if(limitReached)
            {
                MessageBox.Show("This account has reached it's max limit transactions");
                return;
            }

            for (int i = 0; i < transactons.Length; i++)
            {
                if (transactons[i] == null)
                {
                    transactons[i] = transactionDetail;
                    break;
                }
            }
        }
    }
}
