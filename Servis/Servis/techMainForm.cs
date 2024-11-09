using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servis
{
    public partial class techMainForm : Form
    {
        private int technicId;

        public techMainForm(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            technicId = id; // Устанавливаем id клиента

            LoadClientPhoto();
            LoadRequests();
        }

        private void LoadClientPhoto()
        {
            string photoPath = $@"D:\Учебная практика\5 задание\photo\{technicId}.jpg"; // Укажите путь к папке с фото
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
            string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                    R.requestID AS [ID Заявки],
                    R.startDate AS [Дата Начала], 
                    T.techType AS [Тип Техники], 
                    R.problemDescription AS [Описание Проблемы],  
                    RS.statusName AS [Статус] 
            FROM    Requests R
            JOIN    Tech T ON R.techID = T.techID
            JOIN    RequestStatuses RS ON R.statusID = RS.statusID
            WHERE   R.masterID = @masterID";

                SqlCommand cmd = new SqlCommand(query, myCon);
                cmd.Parameters.AddWithValue("@masterID", technicId);
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Очищаем DataGridView и устанавливаем новый источник данных
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = dataTable;

                myCon.Close();
            }
        }

        private void createRepButton_Click(object sender, EventArgs e)
        {
            techReportForm form = new techReportForm(technicId);
            form.DataUpdated += LoadRequests;
            form.Show();
        }
        private void changeButton_Click_1(object sender, EventArgs e)
        {
            techChangeForm form = new techChangeForm(technicId);
            form.DataUpdated += LoadRequests;
            form.Show();
        }

        private void askPartsButton_Click(object sender, EventArgs e)
        {
            techAskPartsForm form = new techAskPartsForm(technicId);
            form.DataUpdated += LoadRequests;
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm form = new loginForm();
            form.Show();
        }
    }
}
