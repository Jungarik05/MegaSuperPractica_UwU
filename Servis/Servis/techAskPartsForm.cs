using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;

namespace Servis
{
    public partial class techAskPartsForm : Form
    {
        private int techID;
        public event Action DataUpdated;
        public techAskPartsForm(int id)
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

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                int partID;
                string partQuery = "SELECT partID FROM Parts WHERE partName = @partName";
                using (SqlCommand partCmd = new SqlCommand(partQuery, myCon))
                {
                    myCon.Open();
                    partCmd.Parameters.AddWithValue("@partName", partComboBox.Text);
                    object result = partCmd.ExecuteScalar(); // Выполняем запрос и получаем первый результат

                    if (result != null)
                    {
                        partID = Convert.ToInt32(result); // Преобразуем результат в int
                    }
                    else
                    {
                        // Обработка случая, когда имя детали не найдено
                        Console.WriteLine("Деталь не найдена.");
                        return; // Прерываем выполнение, если деталь не найдена
                    }
                }

                string createQuery = @"INSERT INTO WorkLogs (requestID, technicianID, workDate, partID, notes) 
                    VALUES (@requestid, @techID, @workDate, @partID , 'запрос детали')";
                SqlCommand cmd1 = new SqlCommand(createQuery, myCon);

                // Параметры запроса
                cmd1.Parameters.AddWithValue("@requestid", reqComboBox.Text);
                cmd1.Parameters.AddWithValue("@techID", techID);
                cmd1.Parameters.AddWithValue("@workDate", DateTime.Now);
                cmd1.Parameters.AddWithValue("@partID", partID);

                
                cmd1.ExecuteNonQuery();
                myCon.Close();

                MessageBox.Show("Деталь успешно заказана");
            }
            // Вызов события после успешного сохранения
            DataUpdated?.Invoke();
            Close(); // Закрытие формы после сохранения
        }
    }
}
