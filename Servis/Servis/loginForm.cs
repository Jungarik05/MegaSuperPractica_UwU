using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servis
{
    public partial class loginForm : Form
    {
        bool textVisible;
        private string captchaText = "";
        private int failedAttempts = 0; // Количество неудачных попыток
        private bool isCaptchaEnabled = false; // Активна ли CAPTCHA
        private Timer blockTimer;

        public loginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            textVisible = false;
            InitializeBlockTimer();
        }
        private void InitializeBlockTimer()
        {
            blockTimer = new Timer(); 
            blockTimer.Interval = 6000; // 3 минуты в миллисекундах
            blockTimer.Tick += BlockTimer_Tick;
            blockTimer.Enabled = false;

        }
        private void BlockTimer_Tick(object sender, EventArgs e)
        {
            // Отключаем таймер после его срабатывания
            blockTimer.Stop();
            enterButton.Visible = true;
            MessageBox.Show("Блокировка снята. Попробуйте снова.");
        }


        private string GenerateCaptchaText(int length) => new string(Enumerable.Repeat("АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789", length).Select(s => s[new Random().Next(s.Length)]).ToArray());

        private Bitmap GenerateCaptchaImage(string text)
        {
            Bitmap bmp = new Bitmap(150, 50);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                for (int i = 0; i < 10; i++) g.DrawLine(Pens.Gray, new Random().Next(150), new Random().Next(50), new Random().Next(150), new Random().Next(50));
                for (int i = 0; i < text.Length; i++) g.DrawString(text[i].ToString(), new Font("Arial", 20, FontStyle.Bold | FontStyle.Strikeout), Brushes.Black, 10 + i * 20, 10);
            }
            return bmp;
        }

        private void RefreshCaptcha()
        {
            captchaText = GenerateCaptchaText(4);
            pictureBoxCaptcha.Image = GenerateCaptchaImage(captchaText);
            pictureBoxCaptcha.Visible = isCaptchaEnabled; // Показываем CAPTCHA только если она активна
        }

        private void toRegLabel_Click(object sender, EventArgs e)
        {
            Hide();
            regForm reg = new regForm();
            reg.Show();
        }
        private void visibleButton_Click(object sender, EventArgs e)
        {
            if (textVisible)
            {
                pasTextBox.PasswordChar = '*';
                textVisible = false;
            }
            else
            {
                pasTextBox.PasswordChar = '\0'; // Отменяет маскирование текста
                textVisible = true;
            }
        }

        private void refButton_Click(object sender, EventArgs e)
        {
            RefreshCaptcha();
        }
        private void enterButton_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                string Query1 = @"SELECT COUNT(*) FROM Users WHERE login = @log AND password = @pas AND roleID = 1";
                string Query2 = @"SELECT COUNT(*) FROM Users WHERE login = @log AND password = @pas AND roleID = 2";
                string Query3 = @"SELECT COUNT(*) FROM Users WHERE login = @log AND password = @pas AND roleID = 3";
                string Query4 = @"SELECT COUNT(*) FROM Users WHERE login = @log";
                string Query5 = @"SELECT COUNT(*) FROM Users WHERE login = @log AND password = @pas AND roleID = 4";

                SqlCommand cmd1 = new SqlCommand(Query1, myCon);
                SqlCommand cmd2 = new SqlCommand(Query2, myCon);
                SqlCommand cmd3 = new SqlCommand(Query3, myCon);
                SqlCommand cmd4 = new SqlCommand(Query4, myCon);
                SqlCommand cmd5 = new SqlCommand(Query5, myCon);

                SqlParameter pr1 = new SqlParameter("@log", logTextBox.Text);
                SqlParameter pr2 = new SqlParameter("@pas", pasTextBox.Text);
                SqlParameter pr3 = new SqlParameter("@log", logTextBox.Text);
                SqlParameter pr4 = new SqlParameter("@pas", pasTextBox.Text);
                SqlParameter pr5 = new SqlParameter("@log", logTextBox.Text);
                SqlParameter pr6 = new SqlParameter("@pas", pasTextBox.Text);
                SqlParameter pr7 = new SqlParameter("@log", logTextBox.Text);
                SqlParameter pr8 = new SqlParameter("@log", logTextBox.Text);
                SqlParameter pr9 = new SqlParameter("@pas", logTextBox.Text);

                cmd1.Parameters.Add(pr1);
                cmd1.Parameters.Add(pr2);
                cmd2.Parameters.Add(pr3);
                cmd2.Parameters.Add(pr4);
                cmd3.Parameters.Add(pr5);
                cmd3.Parameters.Add(pr6);
                cmd4.Parameters.Add(pr7);
                cmd5.Parameters.Add(pr8);
                cmd5.Parameters.Add(pr9);

                myCon.Open();
                if (Convert.ToInt32(cmd4.ExecuteScalar()) == 0)
                {
                    MessageBox.Show("Такого логина не существует!");
                }
                else
                {
                    // Запись в таблицу LoginHistory о попытке входа
                    string loginStatus = "Неуспешная";
                    bool isLoginRecorded = false;

                    if (isCaptchaEnabled && captchaTextBox.Text != captchaText)
                    {
                        MessageBox.Show("Неправильная CAPTCHA.");
                        return;
                    }

                    if (Convert.ToInt32(cmd1.ExecuteScalar()) != 0)
                    {
                        loginStatus = "Успешная";
                        RecordLoginHistory(myCon, logTextBox.Text, loginStatus);
                        isLoginRecorded = true;

                        MessageBox.Show("Данные введены верно. Добро пожаловать!");
                        Hide();
                        string QueryUserID = $@"SELECT userID FROM Users WHERE login = @log";
                        SqlCommand cmdUserID = new SqlCommand(QueryUserID, myCon);
                        SqlParameter prUserID = new SqlParameter("@log", logTextBox.Text);
                        cmdUserID.Parameters.Add(prUserID);
                        object result = cmdUserID.ExecuteScalar();
                        int id = Convert.ToInt32(result);
                        clientForm form = new clientForm(id);
                        form.Show();
                        logTextBox.Text = "";
                        pasTextBox.Text = "";
                        failedAttempts = 0;

                    }
                    else if (Convert.ToInt32(cmd2.ExecuteScalar()) != 0)
                    {
                        loginStatus = "Успешная";
                        RecordLoginHistory(myCon, logTextBox.Text, loginStatus);
                        isLoginRecorded = true;

                        MessageBox.Show("Данные введены верно. Добро пожаловать!");
                        Hide();
                        string QueryTechID = $@"SELECT userID FROM Users WHERE login = @log";
                        SqlCommand cmdTechID = new SqlCommand(QueryTechID, myCon);
                        SqlParameter prTechID = new SqlParameter("@log", logTextBox.Text);
                        cmdTechID.Parameters.Add(prTechID);
                        object result = cmdTechID.ExecuteScalar();
                        int id = Convert.ToInt32(result);
                        techMainForm form = new techMainForm(id);
                        form.Show();
                        logTextBox.Text = "";
                        pasTextBox.Text = "";
                        isCaptchaEnabled = false; // Сбрасываем CAPTCHA
                        failedAttempts = 0;
                        isCaptchaEnabled = false;
                    }
                    else if (Convert.ToInt32(cmd3.ExecuteScalar()) != 0)
                    {
                        loginStatus = "Успешная";
                        RecordLoginHistory(myCon, logTextBox.Text, loginStatus);
                        isLoginRecorded = true;

                        MessageBox.Show("Данные введены верно. Добро пожаловать!");
                        Hide();
                        string QueryAdminID = $@"SELECT userID FROM Users WHERE login = @log";
                        SqlCommand cmdAdminID = new SqlCommand(QueryAdminID, myCon);
                        SqlParameter prAdminID = new SqlParameter("@log", logTextBox.Text);
                        cmdAdminID.Parameters.Add(prAdminID);
                        object result = cmdAdminID.ExecuteScalar();
                        int id = Convert.ToInt32(result);
                        adminMainForm form = new adminMainForm(id);
                        form.Show();
                        logTextBox.Text = "";
                        pasTextBox.Text = "";
                        isCaptchaEnabled = false; // Сбрасываем CAPTCHA
                        failedAttempts = 0;
                        isCaptchaEnabled = false;
                    }
                    else if (Convert.ToInt32(cmd5.ExecuteScalar()) != 0)
                    {
                        loginStatus = "Успешная";
                        RecordLoginHistory(myCon, logTextBox.Text, loginStatus);
                        isLoginRecorded = true;

                        MessageBox.Show("Данные введены верно. Добро пожаловать!");
                        Hide();
                        string QueryManagerID = $@"SELECT userID FROM Users WHERE login = @log";
                        SqlCommand cmdManagerID = new SqlCommand(QueryManagerID, myCon);
                        SqlParameter prManagerID = new SqlParameter("@log", logTextBox.Text);
                        cmdManagerID.Parameters.Add(prManagerID);
                        object result = cmdManagerID.ExecuteScalar();
                        int id = Convert.ToInt32(result);
                        managerMainForm form = new managerMainForm(id);
                        form.Show();
                        logTextBox.Text = "";
                        pasTextBox.Text = "";
                        isCaptchaEnabled = false; // Сбрасываем CAPTCHA
                        failedAttempts = 0;
                        isCaptchaEnabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неверный пароль");
                        if (!isLoginRecorded)
                        {
                            RecordLoginHistory(myCon, logTextBox.Text, loginStatus);
                        }
                        Width = 555;
                        Height = 360;
                        failedAttempts++;
                        if (failedAttempts == 1)
                        {
                            isCaptchaEnabled = true; // Включаем CAPTCHA после первой неудачи
                            RefreshCaptcha(); // Обновляем CAPTCHA
                        }
                        if (failedAttempts == 2)
                        {
                            MessageBox.Show("Слишком много неудачных попыток. Вход заблокирован на 3 минуты.");
                            enterButton.Visible = false;
                            blockTimer.Start(); // Запуск таймера блокировки на 3 минуты
                            return;
                        }
                        if (failedAttempts >= 3)
                        {
                            MessageBox.Show("Слишком много неудачных попыток. Попробуйте позже.");
                            Application.Exit(); // Закрытие приложения после 3 попыток
                        }
                    }
                }
                myCon.Close();
            }       
        // Обновление видимости CAPTCHA
        pictureBoxCaptcha.Visible = isCaptchaEnabled;
        }

    private void RecordLoginHistory(SqlConnection myCon, string login, string status)
        {
            string insertQuery = "INSERT INTO LoginHistory (UserLogin, LoginTime, Status) VALUES (@login, @time, @status)";
            SqlCommand cmdInsert = new SqlCommand(insertQuery, myCon);
            cmdInsert.Parameters.AddWithValue("@login", login);
            cmdInsert.Parameters.AddWithValue("@time", DateTime.Now);
            cmdInsert.Parameters.AddWithValue("@status", status);
            cmdInsert.ExecuteNonQuery();
        }
      
    }
}
