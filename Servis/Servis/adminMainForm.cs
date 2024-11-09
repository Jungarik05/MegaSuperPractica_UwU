using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Servis
{
    public partial class adminMainForm : Form
    {
        int operatorID;
        private HashSet<int> requestIDs;
        public adminMainForm(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            operatorID = id; // Устанавливаем id клиента

            LoadClientPhoto();
            LoadRequests();
        }
        private void LoadClientPhoto()
        {
            string photoPath = $@"D:\Учебная практика\5 задание\photo\{operatorID}.jpg"; // Укажите путь к папке с фото
            if (System.IO.File.Exists(photoPath))
            {
                pictureBoxClientPhoto.Image = Image.FromFile(photoPath);
                pictureBoxClientPhoto.SizeMode = PictureBoxSizeMode.StretchImage; // Растягиваем изображение по размеру PictureBox
            }
            else
            {
                MessageBox.Show("Фото клиента не найдено.");
            }
        }
        public void LoadRequests()
        {
            requestIDs = new HashSet<int>();
            string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";

            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                myCon.Open();
                string totalCountQuery = "SELECT COUNT(*) FROM Requests";

                SqlCommand totalCountCmd = new SqlCommand(totalCountQuery, myCon);
                int totalCount = (int)totalCountCmd.ExecuteScalar();  // Получаем общее количество записей

                // Запрос для выбора всех заявок без фильтрации по masterID
                string query = @"
                    SELECT 
                        R.requestID AS [ID Заявки],
                        R.startDate AS [Дата Начала], 
                        T.techType AS [Тип Техники], 
                        R.problemDescription AS [Описание Проблемы],  
                        RS.statusName AS [Статус],
                        U.fio AS [Мастер]
                    FROM    Requests R
                    JOIN    Tech T ON R.techID = T.techID
                    JOIN    RequestStatuses RS ON R.statusID = RS.statusID
                    LEFT JOIN Users U ON R.masterID = U.userID
                    WHERE   R.statusID != '3'"; 

                SqlCommand cmd = new SqlCommand(query, myCon);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);  // Заполняем DataTable с данными

                // Подсчитываем количество выведенных записей
                int displayedCount = dataTable.Rows.Count;

                // Отображаем информацию о количестве записей на лейбле
                string statusText = $"Показано: {displayedCount} из {totalCount} заявок";
                statusLabel.Text = statusText;  // statusLabel - это Label на форме

                // Очищаем DataGridView и устанавливаем новый источник данных
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = dataTable;

                foreach (DataRow row in dataTable.Rows)
                {
                    requestIDs.Add((int)row["ID Заявки"]); // Добавляем requestID в HashSet
                }

                myCon.Close();
            }
        }


        private void notifButton_Click(object sender, EventArgs e)
        {
            adminNotifForm form = new adminNotifForm(operatorID);
            form.Show();
        }

        private void workLogButton_Click(object sender, EventArgs e)
        {
            adminWorkLogForm form = new adminWorkLogForm();
            form.Show();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTextBox.Text, out int requestId))
            {
                if (requestIDs.Contains(requestId))
                {
                    int id = Convert.ToInt32(idTextBox.Text);
                    adminRequestForm form = new adminRequestForm(id);
                    form.DataUpdated += LoadRequests;
                    form.Show();
                    idTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректный ID заявки.");
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm form = new loginForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginHistory form = new LoginHistory();
            form.Show();
        }
    }
}
