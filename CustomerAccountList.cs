using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class CustomerAccountList
    {

        private static CustomerAccountList instance;
        public List<CustomerAccount> accounts = new List<CustomerAccount>
        {
            new CustomerAccount(1234, "markwellmerto@gmail.com", "Mark Well Merto", "095846325145", "Mabitac, Laguna", "Savings", "jan 9, 2025", 2500000),
            new CustomerAccount(5678, "marielshaneagbagala@gmail.com", "Mariel Shane Agbagala", "09568457125", "Paete, Laguna", "Savings", "jan 5, 2025", 3000000)
        };

        private CustomerAccountList()
        {

        }

        public static CustomerAccountList GetInstance()
        {
            if(instance == null)
            {
                instance = new CustomerAccountList();
            }

            return instance;
        }
    }
}
