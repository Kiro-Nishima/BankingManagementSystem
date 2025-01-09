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

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            string name = textBox3.Text;
            string position = textBox4.Text;
            double salary = Convert.ToDouble(textBox6.Text);

            EmployeeAccount newEmployee = new EmployeeAccount(id, name, position, salary);
            employeesList.accounts.Add(newEmployee);
            DisplayEmployeeInDataGridView();
        }
    }
}
