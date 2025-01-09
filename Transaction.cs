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
    public partial class Transaction : Form
    {
        CustomerAccountList customerAccountList;
        Queue<TransactionDetail> transactions = new Queue<TransactionDetail>();

        public Transaction()
        {
            InitializeComponent();
            customerAccountList = CustomerAccountList.GetInstance();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            string type = textBox3.Text;
            string accountId = textBox1.Text;
            double amount = Convert.ToDouble(textBox4.Text);
            DateTime date = dateTimePicker1.Value;

            // Update account
            TransactionDetail transaction = new TransactionDetail(id, type, accountId, amount, date);
            CustomerAccount account = customerAccountList.accounts.FirstOrDefault(acc => acc.accountId == Convert.ToInt32(accountId));
            if (account != null)
            {
                account.addNewTransaction(transaction);
                if (account.limitReached) return;
            }

            transactions.Enqueue(transaction);
            DisplayStackInDataGridView();
        }

        private void DisplayStackInDataGridView()
        {
            // Convert the stack to a list
            var transactionsList = new List<TransactionDetail>(transactions);

            // Bind the list to the DataGridView
            dataGridView1.DataSource = transactionsList;

            // Optional: Adjust columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            transactions.Dequeue();
            DisplayStackInDataGridView();
        }
    }
}
