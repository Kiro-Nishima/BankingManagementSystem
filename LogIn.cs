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
    public partial class LogIn : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);
        public AdminAccounts adminAccounts;

        public LogIn()
        {
            InitializeComponent();
            adminAccounts = AdminAccounts.GetInstance();
        }

        private void ShowFormInPanel(Form logIn, Panel panelHolder)
        {
            panelHolder.Controls.Clear();

            logIn.TopLevel = false;
            logIn.Dock = DockStyle.Fill;

            panelHolder.Controls.Add(logIn);
            logIn.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            AdminAccount account = adminAccounts.accounts.FirstOrDefault(acc => acc.username == username);
            if(account != null)
            {
                // Kapag nag match yung password
                if(account.password.Equals(password))
                {
                    Program.currentAdmin = account;
                    btnLogIn.Click += (s, e) => ShowFormInPanel(new FormHolder(), Main.showFormPanel);
                } else
                {
                    MessageBox.Show("Invalid credentials");
                }
            } else
            {
                MessageBox.Show("No account was found");
            }

        }
    }
}
