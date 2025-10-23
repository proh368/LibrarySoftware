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
using LibrarySoftware.databaseDataSetTableAdapters;

namespace LibrarySoftware
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.databaseDataSet.Account);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            accountTableAdapter.Update(databaseDataSet);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddAccountForm aaf = new AddAccountForm();
            aaf.Owner = this;
            aaf.Show();
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

        private void accountDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
