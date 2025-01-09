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
    public partial class Account : Form
    {
        CustomerAccountList customerAccountList;

        public Account()
        {
            InitializeComponent();
            customerAccountList = CustomerAccountList.GetInstance();
            DisplayAccountsToDatagridView();
        }

        private void DisplayAccountsToDatagridView()
        {
            dataGridView1.DataSource = customerAccountList.accounts;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
