using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servis
{
    public partial class requestForm : Form
    {
        public event Action DataUpdated;
        private int requestID;
        private int clientID;
        private int masterID;
        public requestForm(int reqID, int cliID, int opID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            requestID = reqID;
            clientID = cliID;
            LoadForm(requestID);
        }
        //Загрузка элментов формы
        private void LoadForm(int id)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();
                string query = "SELECT techType FROM Tech";
                SqlCommand command = new SqlCommand(query, myCon);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    techComboBox.Items.Add(reader["techType"].ToString());
                    }
                }
                if (clientID == 0)
                {
                    string query1 = "SELECT clientID FROM Requests";
                    SqlCommand command1 = new SqlCommand(query1, myCon);
                }
            }

            if (id == 0)
            {
                requestLabel.Text = "Создание заявки";
            }
            else
            {
                requestLabel.Text = "Редактирование заявки";

                string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
                using (SqlConnection myCon = new SqlConnection(connectionString))
                {
                    myCon.Open();
                    string Query1 = @"
                        SELECT T.techType
                        FROM Requests R
                        JOIN Tech T ON R.techID = T.techID
                        WHERE R.requestID = @requestId";
                    string Query2 = @"
                        SELECT techModel
                        FROM Requests
                        WHERE requestID = @requestId";
                    string Query3 = @"
                        SELECT problemDescription
                        FROM Requests 
                        WHERE requestID = @requestId";

                    if (clientID == 0)
                    {

                        string Query4 = @"
                        SELECT masterID
                        FROM Requests 
                        WHERE requestID = @requestId";
                        string Query5 = @"
                        SELECT clientID
                        FROM Requests 
                        WHERE requestID = @requestId";

                        SqlCommand cmd4 = new SqlCommand(Query4, myCon);
                        SqlParameter pr4 = new SqlParameter("@requestId", id);
                        SqlCommand cmd5 = new SqlCommand(Query5, myCon);
                        SqlParameter pr5 = new SqlParameter("@requestId", id);

                        cmd4.Parameters.Add(pr4);
                        cmd5.Parameters.Add(pr5);
                        object master = cmd4.ExecuteScalar();
                        object client = cmd5.ExecuteScalar();

                        ComboBox IDClientComboBox = (ComboBox)this.Controls["IDClientComboBox"];
                        IDClientComboBox.SelectedItem = client.ToString();
                        if (master != DBNull.Value)
                        {
                            ComboBox IDTechComboBox = (ComboBox)this.Controls["IDTechComboBox"];
                            IDTechComboBox.SelectedItem = master.ToString();
                            masterID = Convert.ToInt32(master);
                        }
                        else
                        {
                        }

                    }
                    
                    SqlCommand cmd1 = new SqlCommand(Query1, myCon);
                    SqlParameter pr1 = new SqlParameter("@requestId", id);
                    SqlCommand cmd2 = new SqlCommand(Query2, myCon);
                    SqlParameter pr2 = new SqlParameter("@requestId", id);
                    SqlCommand cmd3 = new SqlCommand(Query3, myCon);
                    SqlParameter pr3 = new SqlParameter("@requestId", id);
                    
                    cmd1.Parameters.Add(pr1);
                    cmd2.Parameters.Add(pr2);
                    cmd3.Parameters.Add(pr3);
                    
                    object techType = cmd1.ExecuteScalar();
                    object techModel = cmd2.ExecuteScalar();
                    object description = cmd3.ExecuteScalar();
                    
                    ComboBox techComboBox = (ComboBox)this.Controls["techComboBox"];
                    techComboBox.SelectedItem = techType.ToString();
                    modelTextBox.Text = techModel.ToString();
                    problemRichTextBox.Text = description.ToString();

                    techComboBox.Enabled = false;
                    modelTextBox.Enabled = false;
                }
            }                  
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {               
                if (requestID > 0) // Редактирование существующей заявки
                {
                    if (clientID == 0)
                    {
                        string updateQuery = @"UPDATE Requests 
                              SET problemDescription = @problemDesc, 
                                  masterID = @masterID
                              WHERE requestID = @requestID";
                        SqlCommand cmd1 = new SqlCommand(updateQuery, myCon);
                        SqlParameter pr1 = new SqlParameter("@problemDesc", problemRichTextBox.Text);
                        SqlParameter pr2 = new SqlParameter("@requestID", requestID);
                        SqlParameter pr3 = new SqlParameter("@masterID", masterID);
                        cmd1.Parameters.Add(pr1);
                        cmd1.Parameters.Add(pr2);
                        cmd1.Parameters.Add(pr3);
                        myCon.Open();
                        cmd1.ExecuteNonQuery();
                        myCon.Close();
                    }
                    else
                    {
                        string updateQuery2 = @"UPDATE Requests 
                              SET problemDescription = @problemDesc 
                              WHERE requestID = @requestID";
                        SqlCommand cmd2 = new SqlCommand(updateQuery2, myCon);
                        SqlParameter pr4 = new SqlParameter("@problemDesc", problemRichTextBox.Text);
                        SqlParameter pr5 = new SqlParameter("@requestID", requestID);
                        cmd2.Parameters.Add(pr4);
                        cmd2.Parameters.Add(pr5);
                        myCon.Open();
                        cmd2.ExecuteNonQuery();
                        myCon.Close();
                    }     
                }
                else // Создание новой заявки
                {
                    // Запрос для получения ID типа техники на основе выбранного techType
                    string getTechTypeIdQuery = "SELECT techID FROM Tech WHERE techType = @techType";
                    SqlCommand cmdGetTechTypeId = new SqlCommand(getTechTypeIdQuery, myCon);
                    cmdGetTechTypeId.Parameters.AddWithValue("@techType", techComboBox.SelectedItem.ToString());

                    myCon.Open();
                    object result = cmdGetTechTypeId.ExecuteScalar();
                    myCon.Close();

                    // Запрос на вставку новой заявки с найденным techID
                    string createQuery = @"INSERT INTO Requests (startDate, techID, problemDesc, statusID, clientID, techModel) 
                       VALUES (@startDate, @techID, @problemDesc, '1' , @clientId, @techModel)";
                    SqlCommand cmd1 = new SqlCommand(createQuery, myCon);
                    
                    // Параметры запроса
                    cmd1.Parameters.AddWithValue("@startDate", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@techID", (int)result);
                    cmd1.Parameters.AddWithValue("@problemDesc", problemRichTextBox.Text);
                    cmd1.Parameters.AddWithValue("@clientId", clientID);
                    cmd1.Parameters.AddWithValue("@techModel", modelTextBox.Text);

                    myCon.Open();
                    cmd1.ExecuteNonQuery();
                    myCon.Close();

                }
                MessageBox.Show(requestID > 0 ? "Заявка успешно обновлена." : "Заявка успешно создана.");              
            }
            // Вызов события после успешного сохранения
            DataUpdated?.Invoke();
            Close(); // Закрытие формы после сохранения
        }

    }

}

