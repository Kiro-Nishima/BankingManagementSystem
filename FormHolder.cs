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
    public partial class FormHolder : Form
    {
        public FormHolder()
        {
            InitializeComponent();

            ShowFormInPanel(new Dashboard(), FormHolderDisplay);
        }

        private void ShowFormInPanel(Form logIn, Panel panelHolder)
        {
            panelHolder.Controls.Clear();

            logIn.TopLevel = false;
            logIn.Dock = DockStyle.Fill;

            panelHolder.Controls.Add(logIn);
            logIn.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.Click += (s, e) => ShowFormInPanel(new Dashboard(), FormHolderDisplay);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnCustomer.Click += (s, e) => ShowFormInPanel(new Customer(), FormHolderDisplay);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            btnAccount.Click += (s, e) => ShowFormInPanel(new Account(), FormHolderDisplay);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            btnTransaction.Click += (s, e) => ShowFormInPanel(new Transaction(), FormHolderDisplay);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            btnEmployee.Click += (s, e) => ShowFormInPanel(new Employees(), FormHolderDisplay);
        }
    }
}
