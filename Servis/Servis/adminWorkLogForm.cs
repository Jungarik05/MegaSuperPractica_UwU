
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Servis
{
    public partial class adminWorkLogForm : Form
    {
        public adminWorkLogForm()
        {
            InitializeComponent();
            LoadClientRequests();
        }
        public void LoadClientRequests()
        {
            string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                            W.logID AS [ID отчета],
                            W.requestID AS [ID Заявки],
                            U.fio AS [Техник],
                            W.workDate AS [Дата выполнения], 
                            P.partName AS [Деталь],
                            W.notes AS [Описание работы] 
                    FROM    WorkLogs W
                    LEFT JOIN    Users U ON W.technicianID = U.userID
                    JOIN    Parts P ON W.partID = P.partID";

                SqlCommand cmd = new SqlCommand(query, myCon);
                myCon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable; // Устанавливаем источник данных для таблицы

                myCon.Close();
            }
        }

    }
}
