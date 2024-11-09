using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servis
{
    public partial class techChangeForm : Form
    {
        private int technicId;
        public event Action DataUpdated;
        public techChangeForm(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            technicId = id;
            LoadForm();
        }
        private void LoadForm( )
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();
                string query = "SELECT requestID FROM Requests WHERE masterID = @master";
                SqlCommand command = new SqlCommand(query, myCon);
                command.Parameters.AddWithValue("@master", technicId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        reqComboBox.Items.Add(reader["requestID"].ToString());
                    }
                }
                string query1 = "SELECT statusName FROM RequestStatuses";
                SqlCommand command1 = new SqlCommand(query1, myCon);
                using (SqlDataReader reader = command1.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statusComboBox.Items.Add(reader["statusName"].ToString());
                    }
                }
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string selectedStatusName = statusComboBox.Text;
            int statusID;

            string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                myCon.Open();

                // Запрос на получение ID статуса по его названию
                string getStatusIdQuery = @"SELECT statusID FROM RequestStatuses WHERE statusName = @statusName";
                using (SqlCommand cmd = new SqlCommand(getStatusIdQuery, myCon))
                {
                    cmd.Parameters.AddWithValue("@statusName", selectedStatusName);
                    object result = cmd.ExecuteScalar();
                    statusID = Convert.ToInt32(result);
                }

                // Запрос на обновление статуса заявки
                string updateRequestQuery = @"UPDATE Requests SET statusID = @statusID WHERE requestID = @requestID";
                using (SqlCommand cmd1 = new SqlCommand(updateRequestQuery, myCon))
                {
                    cmd1.Parameters.AddWithValue("@statusID", statusID);
                    cmd1.Parameters.AddWithValue("@requestID", reqComboBox.Text);
                    cmd1.ExecuteNonQuery();
                }

                MessageBox.Show("Статус заявки успешно обновлен.");
            }
            // Вызов события после успешного сохранения
            DataUpdated?.Invoke();
            Close(); // Закрытие формы после сохранения
        }
    }
}
