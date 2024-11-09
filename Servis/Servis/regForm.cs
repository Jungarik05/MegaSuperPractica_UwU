using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servis
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void toLogLabel_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm f = new loginForm();
            f.Show();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logTextBox.Text) || string.IsNullOrEmpty(pasTextBox.Text) || string.IsNullOrEmpty(pasTextBox2.Text) || string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Заполните пустые поля");
            }
            else if (pasTextBox.Text != pasTextBox2.Text)
            {
                MessageBox.Show("Пароли должны совпадать");
            }
            else
            {
                try
                {
                    string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";

                    SqlConnection myCon = new SqlConnection(connection);
                    myCon.Open();

                    string Query = "insert into Users (fio, phone, login, password, roleID) values ('НЕ Заполнено',@phone,@log, @pass, '1')";
                    SqlCommand cmd = new SqlCommand(Query, myCon);

                    SqlParameter pr1 = new SqlParameter("@log", logTextBox.Text);
                    SqlParameter pr2 = new SqlParameter("@pass", pasTextBox.Text);
                    SqlParameter pr3 = new SqlParameter("@phone", phoneTextBox.Text);

                    cmd.Parameters.Add(pr1);
                    cmd.Parameters.Add(pr2);
                    cmd.Parameters.Add(pr3);

                    string Query2 = $"select count(*) from Users where login = @log";
                    SqlCommand cmd2 = new SqlCommand(Query2, myCon);

                    SqlParameter pr4 = new SqlParameter("@log", logTextBox.Text);
                    cmd2.Parameters.Add(pr4);

                    if (Convert.ToInt32(cmd2.ExecuteScalar()) != 0)
                    {
                        MessageBox.Show("Данный логин уже существует");
                        logTextBox.Text = "";
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Регистрация прошла успешно!");
                        logTextBox.Text = "";
                        pasTextBox.Text = "";
                        pasTextBox2.Text = "";
                        phoneTextBox.Text = "";
                        myCon.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Заполните пустые поля");
                }
            }
        }
    }
}
