using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Servis
{  
    public partial class adminNotifForm : Form
    {
        private int operatorID;
        public adminNotifForm(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            operatorID = id;
            LoadForm();
        }
        private void LoadForm()
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();
                string query = "SELECT DISTINCT clientID FROM Requests";
                SqlCommand command = new SqlCommand(query, myCon);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clientComboBox.Items.Add(reader["clientID"].ToString());
                    }
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сообщение доставлено клиенту");
            Close();
        }
    }
}
