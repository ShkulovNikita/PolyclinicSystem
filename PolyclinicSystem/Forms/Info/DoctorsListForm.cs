using System;
using System.Data;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Info
{
    public partial class DoctorsListForm : Form
    {
        private DataTable dt = new DataTable();

        public DoctorsListForm()
        {
            InitializeComponent();
        }

        private void DoctorsListForm_Load(object sender, EventArgs e)
        {
            //загрузка данных в таблицу
            try
            {
                dt = DoctorsHandler.GetDataTable();
                if ((dt != null) && (dt.Columns.Count > 0))
                {
                    //применить столбцы
                    doctorsDataGrid.DataSource = dt;
                    //отформатировать столбцы
                    doctorsDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    doctorsDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    doctorsDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    //скрыть ID
                    doctorsDataGrid.Columns[0].Visible = false;
                    //загрузить данные
                    doctorsDataGrid.DataSource = DoctorsHandler.FillData(dt);
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
            doctorsDataGrid.DataSource = DoctorsHandler.Search(query, dt);
        }

        //отображение формы с информацией о враче
        private void ShowDoctorForm(DataGridViewRow row)
        {
            if (row.Cells[0].Value != null)
            {
                int ID = Convert.ToInt32(row.Cells[0].Value.ToString());

                //получение выбранного врача
                Doctor doctor = DataHandler.GetDoctor(ID);

                //отображение формы
                DoctorInfoForm doctorInfoForm = new DoctorInfoForm(doctor);
                doctorInfoForm.FormClosed += DoctorInfoForm_FormClosed;
                doctorInfoForm.Show();
            }
            else
                MessagesHandler.ShowMessage("Не выбран врач");
        }

        //обработка выбранной строки таблицы
        private void infoButton_Click(object sender, EventArgs e)
        {
            if (doctorsDataGrid.SelectedRows.Count > 0)
            {
                //получение идентификатора пользователя
                DataGridViewRow row = doctorsDataGrid.SelectedRows[0];
                ShowDoctorForm(row);
            }
            else if (doctorsDataGrid.SelectedCells.Count > 0)
            {
                DataGridViewRow row = doctorsDataGrid.SelectedCells[0].OwningRow;
                ShowDoctorForm(row);
            }
            else
                MessagesHandler.ShowMessage("Не выбран пользователь");
        }

        //обновление таблицы после закрытия окна с врачом
        private void DoctorInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            doctorsDataGrid.DataSource = DoctorsHandler.FillData(dt);
        }
    }
}
