using System;
using System.Data;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Info
{
    public partial class UsersListForm : Form
    {
        private DataTable dt = new DataTable();

        public UsersListForm()
        {
            InitializeComponent();
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {
            //загрузка данных в таблицу
            try
            {
                //получить список столбцов для таблицы
                dt = UsersHandler.GetDataTable();
                if ((dt != null) && (dt.Columns.Count > 0))
                {
                    //применить столбцы
                    usersDataGrid.DataSource = dt;
                    //отформатировать столбцы
                    usersDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    usersDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    usersDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //скрыть ID
                    usersDataGrid.Columns[0].Visible = false;
                    //загрузить данные
                    usersDataGrid.DataSource = UsersHandler.FillData(dt);
                }
                else
                    throw new Exception("Не удалось загрузить таблицу");
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError(ex.Message);
                Close();
            }
        }

        //выполнить поиск
        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = searchTextBox.Text;
            //выполнить поиск и обновить таблицу
            usersDataGrid.DataSource = UsersHandler.Search(query, dt);
        }

        //отображение формы с информацией о пользователе
        private void ShowUserForm(DataGridViewRow row)
        {
            if (row.Cells[0].Value != null)
            {
                int ID = Convert.ToInt32(row.Cells[0].Value.ToString());

                //получение выбранного пользователя
                User user = DataHandler.GetUser(ID);

                //отображение формы
                UserInfoForm userInfoForm = new UserInfoForm(user);
                userInfoForm.FormClosed += UserInfoForm_FormClosed;
                userInfoForm.Show();
            }
            else
                MessagesHandler.ShowMessage("Не выбран пользователь");
        }

        //обработка выбранной строки таблицы
        private void infoButton_Click(object sender, EventArgs e)
        {
            if (usersDataGrid.SelectedRows.Count > 0)
            {
                //получение идентификатора пользователя
                DataGridViewRow row = usersDataGrid.SelectedRows[0];
                ShowUserForm(row);
            }
            else if (usersDataGrid.SelectedCells.Count > 0)
            {
                DataGridViewRow row = usersDataGrid.SelectedCells[0].OwningRow;
                ShowUserForm(row);
            }
            else
                MessagesHandler.ShowMessage("Не выбран пользователь");
        }

        //закрытие формы информации о пользователе
        private void UserInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            usersDataGrid.DataSource = UsersHandler.FillData(dt);
        }

        //добавление нового врача
        private void addUser_Click(object sender, EventArgs e)
        {
            AddDoctorForm addDoctorForm = new AddDoctorForm();
            addDoctorForm.FormClosed += AddDoctorForm_FormClosed;
            addDoctorForm.Show();
        }

        //обновить таблицу при добавлении нового врача
        private void AddDoctorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            usersDataGrid.DataSource = UsersHandler.FillData(dt);
        }
    }
}
