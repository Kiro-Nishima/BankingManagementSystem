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
    public partial class Customer : Form
    {
        CustomerAccountList customerAccountList;
        public Customer()
        {
            InitializeComponent();

            customerAccountList = CustomerAccountList.GetInstance();
            customers.DataSource = customerAccountList.accounts;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                string name = nameInput.Text;
                string phoneNumber = numberInput.Text;
                string email = emailInput.Text;
                string address = addressInput.Text;
                int accountId = Convert.ToInt32(accountIdInput.Text);
                string accountType = typeInput.Text;
                string dateOpened = dateOpenedInput.Text;

                CustomerAccount newAccount = new CustomerAccount(accountId, email, name,phoneNumber, address, accountType, dateOpened, 1);
                customerAccountList.accounts.Add(newAccount);
                RefreshDataGridView();
            } catch (Exception ex)
            {
                MessageBox.Show("Please fill in the necessary information.");
            }
        }

        void RefreshDataGridView()
        {
            customers.DataSource = null;
            customers.DataSource = customerAccountList.accounts;
        }
    }
}
