using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Servis
{
    public partial class adminRequestForm : Form
    {
        public event Action DataUpdated;
        private int requestID;

        public adminRequestForm(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            requestID = id;
            LoadForm(requestID);
        }
        private void LoadForm(int id)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();

                // Запросы для получения данных о заявке
                string techTypeQuery = @"
                    SELECT T.techType
                    FROM Requests R
                    JOIN Tech T ON R.techID = T.techID
                    WHERE R.requestID = @requestId";
                string techModelQuery = @"
                    SELECT techModel
                    FROM Requests
                    WHERE requestID = @requestId";
                string descriptionQuery = @"
                    SELECT problemDescription
                    FROM Requests 
                    WHERE requestID = @requestId";
                string masterFioQuery = @"
                    SELECT U.fio
                    FROM Requests R
                    JOIN Users U ON R.masterID = U.userID
                    WHERE R.requestID = @requestId";
                string clientQuery = @"
                    SELECT clientID
                    FROM Requests 
                    WHERE requestID = @requestId";
                string startDateQuery = @"
                    SELECT startDate
                    FROM Requests
                    WHERE requestID = @requestId";

                // Инициализация команд и добавление параметров
                SqlCommand techTypeCmd = new SqlCommand(techTypeQuery, myCon);
                techTypeCmd.Parameters.AddWithValue("@requestId", id);
                SqlCommand techModelCmd = new SqlCommand(techModelQuery, myCon);
                techModelCmd.Parameters.AddWithValue("@requestId", id);
                SqlCommand descriptionCmd = new SqlCommand(descriptionQuery, myCon);
                descriptionCmd.Parameters.AddWithValue("@requestId", id);
                SqlCommand masterFioCmd = new SqlCommand(masterFioQuery, myCon);
                masterFioCmd.Parameters.AddWithValue("@requestId", id);
                SqlCommand clientCmd = new SqlCommand(clientQuery, myCon);
                clientCmd.Parameters.AddWithValue("@requestId", id);
                SqlCommand startDateCmd = new SqlCommand(startDateQuery, myCon);
                startDateCmd.Parameters.AddWithValue("@requestId", id);

                // Выполнение команд и получение данных
                object techType = techTypeCmd.ExecuteScalar();
                object techModel = techModelCmd.ExecuteScalar();
                object description = descriptionCmd.ExecuteScalar();
                object masterFio = masterFioCmd.ExecuteScalar();
                object client = clientCmd.ExecuteScalar();
                object startDate = startDateCmd.ExecuteScalar();

                // Сохранение даты начала в переменную
                DateTime? startDateValue = startDate != DBNull.Value ? (DateTime?)startDate : null;

                // ComboBox для типа техники
                ComboBox techComboBox = (ComboBox)this.Controls["techComboBox"];
                techComboBox.Items.Clear(); // Очищаем перед заполнением

                // Заполнение доступных типов техники из базы данных
                string techTypesQuery = "SELECT techType FROM Tech";
                SqlCommand techCommand = new SqlCommand(techTypesQuery, myCon);
                using (SqlDataReader reader = techCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        techComboBox.Items.Add(reader["techType"].ToString());
                    }
                }

                // Установка выбранного типа техники
                if (techType != null && techComboBox.Items.Contains(techType.ToString()))
                {
                    techComboBox.SelectedItem = techType.ToString();
                }

                // Поля модели, описания и клиента
                modelTextBox.Text = techModel?.ToString() ?? "";
                problemRichTextBox.Text = description?.ToString() ?? "";

                // ComboBox для ID клиента
                ComboBox IDClientComboBox = (ComboBox)this.Controls["IDClientComboBox"];
                IDClientComboBox.Items.Clear();

                // Загрузка клиентских ID
                string clientIdsQuery = "SELECT DISTINCT clientID FROM Requests";
                SqlCommand clientCommand = new SqlCommand(clientIdsQuery, myCon);
                using (SqlDataReader reader = clientCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IDClientComboBox.Items.Add(reader["clientID"].ToString());
                    }
                }

                // Установка значения для ID клиента
                if (client != null)
                {
                    IDClientComboBox.SelectedItem = client.ToString();
                }

                // ComboBox для мастера, заполненного ФИО
                ComboBox IDTechComboBox = (ComboBox)this.Controls["IDTechComboBox"];
                IDTechComboBox.Items.Clear(); // Очищаем перед добавлением новых значений

                // Загрузка всех ФИО техников из таблицы Users
                string mastersQuery = "SELECT fio FROM Users WHERE roleID = '2'";
                SqlCommand mastersCommand = new SqlCommand(mastersQuery, myCon);
                using (SqlDataReader reader = mastersCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IDTechComboBox.Items.Add(reader["fio"].ToString());
                    }
                }

                // Установка значения для ФИО техника
                if (masterFio != null)
                {
                    IDTechComboBox.SelectedItem = masterFio.ToString();
                }

                // Блокировка ComboBox для ID клиента и типа техники
                IDClientComboBox.Enabled = false;
                techComboBox.Enabled = false;

                // Теперь переменная startDateValue содержит дату начала заявки
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";

            // Сначала собираем все необходимые данные из формы
            string selectedTechType = techComboBox.SelectedItem.ToString();
            string model = modelTextBox.Text;
            string problemDescription = problemRichTextBox.Text;
            string selectedClientID = IDClientComboBox.SelectedItem.ToString();
            string selectedMasterFio = IDTechComboBox.SelectedItem?.ToString();

            // Получаем ID типа техники по выбранному имени типа
            int techID = GetTechID(selectedTechType);  // Функция получения ID техники

            // Создание соединения с базой данных
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();

                // Подготовка SQL запроса для обновления данных заявки
                string updateQuery = @"
                    UPDATE Requests
                    SET techID = @techID,                  
                        techModel = @techModel,
                        problemDescription = @problemDesc,
                        masterID = (SELECT userID FROM Users WHERE fio = @masterFio),
                        clientID = @clientID
                    WHERE requestID = @requestId";

                SqlCommand cmd = new SqlCommand(updateQuery, myCon);

                // Добавляем параметры в запрос
                cmd.Parameters.AddWithValue("@techID", techID);   // Используем techID вместо типа техники
                cmd.Parameters.AddWithValue("@techModel", model);
                cmd.Parameters.AddWithValue("@problemDesc", problemDescription);
                cmd.Parameters.AddWithValue("@clientID", selectedClientID);
                cmd.Parameters.AddWithValue("@requestId", requestID);

                if (string.IsNullOrEmpty(selectedMasterFio))
                {
                    cmd.Parameters.AddWithValue("@masterFio", DBNull.Value);  // Если мастер не выбран, передаем DBNull
                }
                else
                {
                    cmd.Parameters.AddWithValue("@masterFio", selectedMasterFio);
                }

                // Выполнение запроса
                cmd.ExecuteNonQuery();
                MessageBox.Show("Заявка успешно сохранена.");

                DataUpdated?.Invoke();
                Close();  // Закрытие формы после сохранения
            }
        }
        private int GetTechID(string techType)
        {
            int techID = 0;
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";

            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();
                string query = "SELECT techID FROM Tech WHERE techType = @techType";
                SqlCommand cmd = new SqlCommand(query, myCon);
                cmd.Parameters.AddWithValue("@techType", techType);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    techID = Convert.ToInt32(result);
                }
            }
            return techID;
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (IDTechComboBox.SelectedItem == null)
            {
                MessageBox.Show("Ошибка: Не выбран мастер! Заявку нельзя закрыть без выбора мастера.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение, если мастер не выбран
            }

            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";

            // Сначала собираем все необходимые данные из формы
            string selectedMasterFio = IDTechComboBox.SelectedItem.ToString();  // ФИО выбранного мастера
            string model = modelTextBox.Text;
            string problemDescription = problemRichTextBox.Text;
            string selectedClientID = IDClientComboBox.SelectedItem.ToString();

            // Получаем ID мастера по выбранному ФИО
            int masterID = GetMasterID(selectedMasterFio);  // Функция получения ID мастера
            DateTime currentTime = DateTime.Now;  // Текущее время для завершения заявки

            // Создание соединения с базой данных
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();

                // Подготовка SQL запроса для обновления данных заявки (закрытие заявки)
                string updateQuery = @"
                    UPDATE Requests
                    SET masterID = @masterID,                  
                        techModel = @techModel,
                        problemDescription = @problemDesc,
                        clientID = @clientID,
                        statusID = '3',
                        completionDate = @completionDate   
                    WHERE requestID = @requestId";

                SqlCommand cmd = new SqlCommand(updateQuery, myCon);

                // Добавляем параметры в запрос
                cmd.Parameters.AddWithValue("@masterID", masterID);   // Используем masterID вместо типа техники
                cmd.Parameters.AddWithValue("@techModel", model);
                cmd.Parameters.AddWithValue("@problemDesc", problemDescription);
                cmd.Parameters.AddWithValue("@clientID", selectedClientID);
                cmd.Parameters.AddWithValue("@requestId", requestID);
                cmd.Parameters.AddWithValue("@completionDate", currentTime); // Добавляем текущее время для завершения

                // Выполнение запроса
                cmd.ExecuteNonQuery();
                MessageBox.Show("Заявка успешно закрыта.");

                DataUpdated?.Invoke();
                Close();  // Закрытие формы после сохранения
            }
        }
        private int GetMasterID(string masterFio)
        {
            string connection = @"Data Source=ADCLG1;Initial Catalog=VodvudyanPRACT;Integrated Security=True";
            using (SqlConnection myCon = new SqlConnection(connection))
            {
                myCon.Open();

                // Запрос для получения userID мастера по его ФИО
                string query = "SELECT userID FROM Users WHERE fio = @masterFio AND roleID = 2"; // 2 - роль мастера

                SqlCommand cmd = new SqlCommand(query, myCon);
                cmd.Parameters.AddWithValue("@masterFio", masterFio);  // Передаем ФИО мастера как параметр

                object result = cmd.ExecuteScalar();  // Выполняем запрос и получаем результат

                // Если мастер найден, возвращаем его userID, иначе 0
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

    }
}
