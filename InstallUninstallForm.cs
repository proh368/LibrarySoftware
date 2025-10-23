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
    public partial class InstallUninstallForm : Form
    {
        public InstallUninstallForm()
        {
            InitializeComponent();
        }

        private void InstallUninstallForm_Load(object sender, EventArgs e)
        {
            this.install_UninstallTableAdapter.Fill(this.databaseDataSet.Install_Uninstall);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            install_UninstallTableAdapter.Update(databaseDataSet);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddInstallUninstallForm aiuf = new AddInstallUninstallForm();
            aiuf.Owner = this;
            aiuf.Show();
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

        public void OpenAddInstallUninstallForm()
        {
            Application.Run(new AddInstallUninstallForm());
        }

        private void installUninstallDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
