using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class AdminAccounts
    {
        private static AdminAccounts instance;
        public List<AdminAccount> accounts = new List<AdminAccount>();

        private AdminAccounts()
        {
            accounts.Add(new AdminAccount("admin1", "admin1", "Admin 1"));
            accounts.Add(new AdminAccount("admin2", "admin2", "Admin 2"));
            accounts.Add(new AdminAccount("admin3", "admin3", "Admin 3"));
        }

        public static AdminAccounts GetInstance()
        {
            if (instance == null)
            {
                instance = new AdminAccounts();
            }

            return instance;
        }
    }
}
