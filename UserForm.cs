using LibrarySoftware.databaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySoftware
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.databaseDataSet.User);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            userTableAdapter.Update(databaseDataSet);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenMainForm);
            thread.Start();
        }

        public void OpenMainForm()
        {
            Application.Run(new MainForm());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddUserForm auf = new AddUserForm();
            auf.Owner = this;
            auf.Show();
        }

        private void userDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
