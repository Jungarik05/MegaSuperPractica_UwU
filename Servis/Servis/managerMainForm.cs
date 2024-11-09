using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Servis
{
    public partial class managerMainForm : Form
    {
        private int managerID;
        private HashSet<int> requestIDs;

        public managerMainForm(int id)
        {
            InitializeComponent();
            managerID = id; // Исправлено присваивание managerID
            LoadClientPhoto();
            LoadRequests();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;

            // Устанавливаем свойства DataGridView для редактирования
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void LoadClientPhoto()
        {
            string photoPath = $@"D:\Учебная практика\5 задание\photo\{managerID}.jpg";
            if (System.IO.File.Exists(photoPath))
            {
                pictureBoxClientPhoto.Image = Image.FromFile(photoPath);
                pictureBoxClientPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
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
                string query = @"
                    SELECT 
                        R.requestID AS [ID Заявки],
                        R.startDate AS [Дата Начала], 
                        T.techType AS [Тип Техники], 
                        R.problemDescription AS [Описание Проблемы], 
                        R.completionDate AS [Дата Окончания], 
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
                adapter.Fill(dataTable);

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = dataTable;

                dataGridView1.ReadOnly = false;
                dataGridView1.Columns["ID Заявки"].ReadOnly = true; // ID заявки не редактируемый

                foreach (DataRow row in dataTable.Rows)
                {
                    requestIDs.Add((int)row["ID Заявки"]);
                }
                myCon.Close();
            }
        }

        private void notifButton_Click(object sender, EventArgs e)
        {
            adminNotifForm form = new adminNotifForm(managerID);
            form.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";

            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                myCon.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    int requestId = (int)row.Cells["ID Заявки"].Value;
                    string completionDate = row.Cells["Дата Окончания"].Value?.ToString();
                    string master = row.Cells["Мастер"].Value?.ToString();

                    string updateQuery = @"
                        UPDATE Requests
                        SET 
                            completionDate = @completionDate,
                            masterID = (SELECT userID FROM Users WHERE fio = @master)
                        WHERE requestID = @requestId";

                    SqlCommand cmd = new SqlCommand(updateQuery, myCon);
                    cmd.Parameters.AddWithValue("@completionDate", string.IsNullOrEmpty(completionDate) ? (object)DBNull.Value : completionDate);
                    cmd.Parameters.AddWithValue("@master", string.IsNullOrEmpty(master) ? (object)DBNull.Value : master);
                    cmd.Parameters.AddWithValue("@requestId", requestId);

                    cmd.ExecuteNonQuery();
                }

                myCon.Close();
                MessageBox.Show("Изменения успешно сохранены.");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            loginForm form = new loginForm();
            form.Show();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Активируем кнопку сохранения, если есть изменения в таблице
            saveButton.Enabled = true;
        }
    }
}
