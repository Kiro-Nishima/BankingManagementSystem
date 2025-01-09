using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingManagementSystem
{
    public class EmployeeAccount
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public double  salary { get; set; }

        public EmployeeAccount(int id, string name, string position, double salary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.salary = salary;
        }
    }
}
