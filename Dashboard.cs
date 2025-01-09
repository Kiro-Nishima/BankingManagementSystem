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
        public Dashboard()
        {
            InitializeComponent();

            AdminAccount currentAdmin = Program.currentAdmin;
            adminName.Text = $"Welcome, {currentAdmin.name}";
        }
    }
}
