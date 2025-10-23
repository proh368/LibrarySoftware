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
    public partial class AddProgramForm : Form
    {
        public AddProgramForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ListProgramForm main = this.Owner as ListProgramForm;
            if (main != null)
            {
                DataRow nRow = main.databaseDataSet.Tables[0].NewRow();
                int rc = main.listProgramDGV.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = nameTxt.Text;
                nRow[2] = versionTxt.Text;
                nRow[3] = typeTxt.Text;
                nRow[4] = firmTxt.Text;
                nRow[5] = releaseTxt.Text;
                nRow[6] = applicationAreaTxt.Text;
                nRow[7] = costLicenseNum.Value;
                main.databaseDataSet.Tables[0].Rows.Add(nRow);
                main.listProgramTableAdapter.Update(main.databaseDataSet.ListProgram);
                main.databaseDataSet.Tables[0].AcceptChanges();
                main.listProgramDGV.Refresh();
                nameTxt.Text = "";
                versionTxt.Text = "";
                typeTxt.Text = "";
                firmTxt.Text = "";
                releaseTxt.Text = "";
                applicationAreaTxt.Text = "";
                costLicenseNum.Value = 1;
                MessageBox.Show("Данные добавлены!");
                Application.Exit();
                var thread = new Thread(OpenListProgramForm);
                thread.Start();
            }
        }

        public void OpenListProgramForm()
        {
            Application.Run(new ListProgramForm());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
