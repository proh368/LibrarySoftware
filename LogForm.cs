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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibrarySoftware
{
    public partial class LogForm : Form
    {
        public bool roleAccount;
        public LogForm()
        {
            InitializeComponent();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=E:\УП ПМ 06 Чистяков Иван\LibrarySoftware\bin\Debug\database.accdb";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(loginTxt.Text) || string.IsNullOrWhiteSpace(passwordTxt.Text))
                    {
                        MessageBox.Show("Логин или пароль не могут быть пустыми.");
                        return;
                    }

                    con.Open();
                    string query = "SELECT role FROM Account WHERE login = ? AND password = ?";

                    OleDbCommand cmd = new OleDbCommand(query, con);

                        cmd.Parameters.AddWithValue("?", loginTxt.Text);
                        cmd.Parameters.AddWithValue("?", passwordTxt.Text);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();
                            Program.UserRole = role;
                            Application.Exit();
                            var thread = new Thread(OpenMainForm);
                            thread.SetApartmentState(ApartmentState.STA);
                            thread.Start();
                        }
                        else
                        {
                            MessageBox.Show("Неправильно введённые имя или пароль");
                        }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=E:\УП ПМ 06 Чистяков Иван\LibrarySoftware\bin\Debug\database.accdb";

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(loginTxt.Text) || string.IsNullOrWhiteSpace(passwordTxt.Text))
                    {
                        MessageBox.Show("Логин или пароль не могут быть пустыми.");
                        return;
                    }

                    con.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [Account] WHERE [login] = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("?", loginTxt.Text);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует.");
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO [Account] ([login], [password], [role]) VALUES (?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("?", loginTxt.Text);
                        insertCmd.Parameters.AddWithValue("?", passwordTxt.Text);
                        insertCmd.Parameters.AddWithValue("?", "Пользователь");

                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Регистрация прошла успешно.");
                            Program.UserRole = "Пользователь";
                            Application.Exit();
                            var thread = new Thread(OpenMainForm);
                            thread.Start();
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при регистрации.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных: " + ex.Message);
                }
            }
        }

        public void OpenMainForm()
        {
            Application.Run(new MainForm());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
