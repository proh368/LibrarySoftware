using LibrarySoftware.databaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySoftware
{
    public partial class ListProgramForm : Form
    {

        public ListProgramForm()
        {
            InitializeComponent();
        }

        private void AddProgramForm_Load(object sender, EventArgs e)
        {
            this.listProgramTableAdapter.Fill(this.databaseDataSet.ListProgram);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            listProgramTableAdapter.Update(databaseDataSet);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var thread = new Thread(OpenMainForm);
            thread.Start();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddProgramForm apf = new AddProgramForm();
            apf.Owner = this;
            apf.Show();
        }

        public void OpenMainForm()
        {
            Application.Run(new MainForm());
        }

        private void listProgramDGV_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
