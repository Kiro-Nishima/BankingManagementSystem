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
    public partial class Employees : Form
    {
        EmployeesList employeesList;
        EmployeeAccount account;

        public Employees()
        {
            InitializeComponent();
            employeesList = EmployeesList.GetInstance();
            DisplayEmployeeInDataGridView();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DisplayEmployeeInDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = employeesList.accounts;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Add new employee
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox5.Text);
                string name = textBox3.Text;
                string position = textBox4.Text;
                double salary = Convert.ToDouble(textBox6.Text);

                EmployeeAccount newEmployee = new EmployeeAccount(id, name, position, salary);
                employeesList.accounts.Add(newEmployee);
                DisplayEmployeeInDataGridView();
            } catch (Exception ex)
            {
                MessageBox.Show("Please fill in the necessary information.");
            }
        }

        // Update employee details
        private void button4_Click(object sender, EventArgs e)
        {
            if (account == null) return;

            account.id = Convert.ToInt32(textBox5.Text);
            account.name = textBox3.Text;
            account.position = textBox4.Text;
            account.salary = Convert.ToDouble(textBox6.Text);

            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

            DisplayEmployeeInDataGridView();
            account = null;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];
            int accId = Convert.ToInt32(clickedRow.Cells["id"].Value);

            account = employeesList.accounts.FirstOrDefault(acc => acc.id == accId);
            if (account != null)
            {
                textBox5.Text = account.id.ToString();
                textBox3.Text = account.name.ToString();
                textBox4.Text = account.position.ToString();
                textBox6.Text = account.salary.ToString();
            }
        }

        //Delete an employee account
        private void button5_Click(object sender, EventArgs e)
        {
            if (account == null) return;

            employeesList.accounts.Remove(account);
            account = null;
            textBox5.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

            DisplayEmployeeInDataGridView();
        }
    }
}
