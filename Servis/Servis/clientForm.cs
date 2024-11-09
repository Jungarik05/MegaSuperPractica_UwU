using System;
using QRCoder;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Servis
{
    public partial class clientForm : Form
    {
        private int clientId;
        private HashSet<int> clientRequestIds;

        public clientForm(int id)
        {
            InitializeComponent();

            string textToEncode = "https://plants-vs-zombies.fandom.com/ru/wiki/%D0%9F%D0%BE%D0%B4%D1%81%D0%BE%D0%BB%D0%BD%D1%83%D1%85";

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(textToEncode,  QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
                    {
                        QRpictureBox.Image = new Bitmap(qrCodeImage);
                    }
                }
            }


            StartPosition = FormStartPosition.CenterScreen;
            clientId = id; // Устанавливаем id клиента

            LoadClientPhoto();
            LoadClientRequests();
        }

        private void LoadClientPhoto()
        {
            string photoPath = $@"D:\Учебная практика\5 задание\photo\{clientId}.jpg"; // Укажите путь к папке с фото
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

        public void LoadClientRequests()
        {
            clientRequestIds = new HashSet<int>();
            string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                            R.requestID AS [ID Заявки],
                            R.startDate AS [Дата Начала], 
                            T.techType AS [Тип Техники], 
                            R.problemDescription AS [Описание Проблемы], 
                            R.completionDate AS [Дата Завершения], 
                            RS.statusName AS [Статус] 
                    FROM    Requests R
                    JOIN    Tech T ON R.techID = T.techID
                    JOIN    RequestStatuses RS ON R.statusID = RS.statusID
                    WHERE   R.clientID = @clientId";

                SqlCommand cmd = new SqlCommand(query, myCon);
                cmd.Parameters.AddWithValue("@clientId", clientId);
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable; // Устанавливаем источник данных для таблицы
                                                      // Добавляем requestID в HashSet
                foreach (DataRow row in dataTable.Rows)
                {
                    clientRequestIds.Add((int)row["ID Заявки"]); // Добавляем requestID в HashSet
                }
                myCon.Close();
            }
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            requestForm form = new requestForm(0, clientId, 0);
            form.DataUpdated += LoadClientRequests;
            form.Show();
            idTextBox.Text = "";
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(idTextBox.Text, out int requestId))
            {
                if (clientRequestIds.Contains(requestId))
                {
                    int id = Convert.ToInt32(idTextBox.Text);
                    requestForm form = new requestForm(id, clientId, 0);
                    form.DataUpdated += LoadClientRequests;
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
    }
}
