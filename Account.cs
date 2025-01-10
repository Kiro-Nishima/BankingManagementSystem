using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BankingManagementSystem
{
    public partial class Account : Form
    {
        CustomerAccountList customerAccountList;
        CustomerAccount account;

        public Account()
        {
            InitializeComponent();
            customerAccountList = CustomerAccountList.GetInstance();
            DisplayAccountsToDatagridView();
        }

        private void DisplayAccountsToDatagridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = customerAccountList.accounts;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];
            int accId = Convert.ToInt32(clickedRow.Cells["accountId"].Value);

            account = customerAccountList.accounts.FirstOrDefault(acc => acc.accountId == accId);
            if (account != null)
            {
                textBox5.Text = account.accountId.ToString();
                textBox3.Text = account.accountType;
                textBox4.Text = account.name;
                textBox6.Text = account.balance.ToString();
            }
        }


        // Update account
        private void button4_Click(object sender, EventArgs e)
        {
            if (account == null) return;

            account.accountId = Convert.ToInt32(textBox5.Text);
            account.name = textBox4.Text;
            account.accountType = textBox3.Text;
            account.balance = Convert.ToInt32(textBox6.Text);

            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

            DisplayAccountsToDatagridView();
            account = null;
        }

        // Delete account
        private void button5_Click(object sender, EventArgs e)
        {
            if (account == null) return;

            customerAccountList.accounts.Remove(account);
            account = null;
            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            DisplayAccountsToDatagridView();
        }
    }
}
