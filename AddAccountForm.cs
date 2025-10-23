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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Account". При необходимости она может быть перемещена или удалена.
            this.accountTableAdapter.Fill(this.databaseDataSet.Account);

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenAccountForm);
            thread.Start();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AccountForm main = this.Owner as AccountForm;
            if (main != null)
            {
                DataRow nRow = main.databaseDataSet.Tables[0].NewRow();
                int rc = main.accountDGV.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = loginTxt.Text;
                nRow[2] = passwordTxt.Text;
                nRow[3] = roleCBox.Text;
                main.databaseDataSet.Tables[0].Rows.Add(nRow);
                main.accountTableAdapter.Update(main.databaseDataSet.Account);
                main.databaseDataSet.Tables[0].AcceptChanges();
                main.accountDGV.Refresh();
                loginTxt.Text = "";
                passwordTxt.Text = "";
                roleCBox.Text = "";
                MessageBox.Show("Данные добавлены!");
                Application.Exit();
                var thread = new Thread(OpenAccountForm);
                thread.Start();
            }
        }

        public void OpenAccountForm()
        {
            Application.Run(new AccountForm());
        }
    }
}
