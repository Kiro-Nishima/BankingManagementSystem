using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class EmployeesList
    {
        private static EmployeesList instance;
        public List<EmployeeAccount> accounts = new List<EmployeeAccount>();

        private EmployeesList()
        {
            accounts.Add(new EmployeeAccount(10, "Tolentino, James Bryan", "Accounting Manager", 43000));
            accounts.Add(new EmployeeAccount(11, "Cabañero, Nice Given", "Financial Analyst", 50000));
            accounts.Add(new EmployeeAccount(12, "Maguyon, Bjorn Marek", "Stock Broker", 38000));
            accounts.Add(new EmployeeAccount(13, "Damian, Kayeri Clayer", "Loan Specialist", 37000));
            accounts.Add(new EmployeeAccount(14, "Gemanel, John Kraeven", "Client Officer", 30000));
        }

        public static EmployeesList GetInstance()
        {
            if(instance == null)
            {
                instance = new EmployeesList();
            }

            return instance;
        }
    }
}
