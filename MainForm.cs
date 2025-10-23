using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibrarySoftware.databaseDataSet;

namespace LibrarySoftware
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string currentUserLogin;

        private void listProgramBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenAddProgramForm);
            thread.Start();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenUserForm);
            thread.Start();
        }

        private void instUninstBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenInstUninstForm);
            thread.Start();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenLogForm);
            thread.Start();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenAccountForm);
            thread.Start();
        }

        public void OpenLogForm()
        {
            Application.Run(new LogForm());
        }

        public void OpenAddProgramForm()
        {
            Application.Run(new ListProgramForm());
        }

        public void OpenUserForm()
        {
            Application.Run(new UserForm());
        }

        public void OpenInstUninstForm()
        {
            Application.Run(new InstallUninstallForm());
        }

        public void OpenAccountForm()
        {
            Application.Run(new AccountForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.check_lastMonth_BeforeLastMonthTableAdapter.Fill(this.databaseDataSet1.Check_lastMonth_BeforeLastMonth);
            if (Program.UserRole == "Администратор")
            {
                accountBtn.Visible = true; 
            }
            else
            {
                accountBtn.Visible = false;
            }
        }
    }
    
}
