using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagementSystem
{
    public partial class Dashboard : Form
    {
        AdminAccounts adminAccounts;
        EmployeesList employeesList;
        CustomerAccountList customerAccountList;
        TransactionList transactionList;

        public Dashboard()
        {
            InitializeComponent();
            adminAccounts = AdminAccounts.GetInstance();
            employeesList = EmployeesList.GetInstance();
            customerAccountList = CustomerAccountList.GetInstance();
            transactionList = TransactionList.GetInstance();

            AdminAccount currentAdmin = Program.currentAdmin;
            adminName.Text = $"Welcome, {currentAdmin.name}";
            label2.Text = adminAccounts.accounts.Count.ToString();
            label3.Text = employeesList.accounts.Count.ToString();
            noOfAccounts.Text = customerAccountList.accounts.Count.ToString();
            label16.Text = transactionList.transactions.Count.ToString();

            DisplayEmployeeInDataGridView();
        }

        private void DisplayEmployeeInDataGridView()
        {
            dataGridView1.DataSource = employeesList.accounts;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
