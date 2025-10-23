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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            this.accountTableAdapter.Fill(this.databaseDataSet.Account);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            UserForm main = this.Owner as UserForm;
            if (main != null)
            {
                DataRow nRow = main.databaseDataSet.Tables[0].NewRow();
                int rc = main.userDGV.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = fioTxt.Text;
                nRow[2] = regionTxt.Text;
                nRow[3] = sphereUseTxt.Text;
                nRow[4] = idAccountCBox.Text;
                main.databaseDataSet.Tables[0].Rows.Add(nRow);
                main.userTableAdapter.Update(main.databaseDataSet.User);
                main.databaseDataSet.Tables[0].AcceptChanges();
                main.userDGV.Refresh();
                fioTxt.Text = "";
                regionTxt.Text = "";
                sphereUseTxt.Text = "";
                idAccountCBox.Text = "";
                MessageBox.Show("Данные добавлены!");
                Application.Exit();
                var thread = new Thread(OpenUserForm);
                thread.Start();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void OpenUserForm()
        {
            Application.Run(new UserForm());
        }
    }
}
