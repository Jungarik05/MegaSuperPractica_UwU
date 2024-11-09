using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servis
{
    public partial class techReportForm : Form
    {
        private int techID;
        public event Action DataUpdated;
        public techReportForm(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            techID = id;
            LoadForm(techID);
        }
        private void LoadForm(int id)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();
                string query = "SELECT requestID FROM Requests WHERE masterID = @master";
                SqlCommand command = new SqlCommand(query, myCon);
                command.Parameters.AddWithValue("@master", techID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reqComboBox.Items.Add(reader["requestID"].ToString());
                    }
                }
                string query1 = "SELECT partName FROM Parts";
                SqlCommand command1 = new SqlCommand(query1, myCon);
                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        partComboBox.Items.Add(reader["partName"].ToString());
                    }
                }
            }           
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                if (partComboBox.SelectedIndex != -1)
                {
                    // Запрос на вставку новой заявки с найденным techID
                    string createQuery = @"INSERT INTO WorkLogs (requestID, technicianID, workDate, partID, notes) 
                    VALUES (@requestid, @techID, @workDate, @partID , @notes)";
                    SqlCommand cmd1 = new SqlCommand(createQuery, myCon);

                    // Параметры запроса
                    cmd1.Parameters.AddWithValue("@requestid", reqComboBox.Text);
                    cmd1.Parameters.AddWithValue("@techID", techID);
                    cmd1.Parameters.AddWithValue("@workDate", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@partID", partComboBox.Text);
                    cmd1.Parameters.AddWithValue("@notes", noteRichTextBox.Text);

                    myCon.Open();
                    cmd1.ExecuteNonQuery();
                    myCon.Close();
                }
                else
                {
                    // Запрос на вставку новой заявки с найденным techID
                    string createQuery = @"INSERT INTO WorkLogs (requestID, technicianID, workDate, notes) 
                    VALUES (@requestid, @techID, @workDate, @notes)";
                    SqlCommand cmd1 = new SqlCommand(createQuery, myCon);

                    // Параметры запроса
                    cmd1.Parameters.AddWithValue("@requestid", reqComboBox.Text);
                    cmd1.Parameters.AddWithValue("@techID", techID);
                    cmd1.Parameters.AddWithValue("@workDate", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@notes", noteRichTextBox.Text);

                    myCon.Open();
                    cmd1.ExecuteNonQuery();
                    myCon.Close();
                }
                
                MessageBox.Show("Отчет успешно сформирован");

            }
            // Вызов события после успешного сохранения
            DataUpdated?.Invoke();
            Close(); // Закрытие формы после сохранения
        }
    }
}
