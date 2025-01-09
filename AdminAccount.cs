using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class AdminAccount
    {
        public string username;
        public string password;
        public string name;

        public AdminAccount(string username, string password, string name)
        {
            this.username = username;
            this.password = password;
            this.name = name;
        }
    }
}
