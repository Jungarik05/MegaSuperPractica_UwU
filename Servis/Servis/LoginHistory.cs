using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Servis
{
    public partial class LoginHistory : Form
    {
        public LoginHistory()
        {
            InitializeComponent();
            LoadRequests();
        }
        public void LoadRequests()
        {
            string connectionString = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";

            using (SqlConnection myCon = new SqlConnection(connectionString))
            {
                myCon.Open();

                string query = @"
                    SELECT*
                    FROM LoginHistory";

                SqlCommand cmd = new SqlCommand(query, myCon);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);  // Заполняем DataTable с данными

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = dataTable;

                myCon.Close();
            }
        }
    }
}
