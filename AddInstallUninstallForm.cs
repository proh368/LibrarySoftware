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
    public partial class AddInstallUninstallForm : Form
    {
        public AddInstallUninstallForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InstallUninstallForm main = this.Owner as InstallUninstallForm;
            if (main != null)
            {
                DataRow nRow = main.databaseDataSet.Tables[0].NewRow();
                int rc = main.installUninstallDGV.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = costTxt.Text;
                nRow[2] = dateInstallationTxt.Text;
                nRow[3] = dateUninstallationTxt.Text;
                nRow[4] = countLicensesNum.Value;
                main.databaseDataSet.Tables[0].Rows.Add(nRow);
                main.install_UninstallTableAdapter.Update(main.databaseDataSet.Install_Uninstall);
                main.databaseDataSet.Tables[0].AcceptChanges();
                main.installUninstallDGV.Refresh();
                costTxt.Text = "";
                dateInstallationTxt.Text = "";
                dateUninstallationTxt.Text = "";
                countLicensesNum.Value = 1;
                MessageBox.Show("Данные добавлены!");
                Application.Exit();
                var thread = new Thread(OpenInstallUninstallForm);
                thread.Start();
            }
        }

        public void OpenInstallUninstallForm()
        {
            Application.Run(new InstallUninstallForm());
        }
    }
}
