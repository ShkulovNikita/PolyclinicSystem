using System;
using System.Windows.Forms;
using PolyclinicSystem.Forms.Functions;
using PolyclinicSystem.Forms.Info;

namespace PolyclinicSystem.Forms
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void visitsButton_Click(object sender, EventArgs e)
        {
            VisitsListForm visitsForm = new VisitsListForm();
            visitsForm.Show();
        }

        private void InitializeLabels()
        {
            try
            {
                nameLabel.Text = "ФИО: " + MainForm.CurPatient.User.Name;
                omsLabel.Text = "ОМС: " + MainForm.CurPatient.OMS;
                phoneLabel.Text = "Телефон: " + MainForm.CurPatient.Phone;
                jobPlaceLabel.Text = "Место работы/учебы: " + MainForm.CurPatient.JobPlace;
                addressLabel.Text = "Адрес:\n" + MainForm.CurPatient.Address;
                birthdateLabel.Text = "Дата рождения: " + MainForm.CurPatient.BirthDate;

                if (MainForm.CurPatient.Gender == "м")
                    genderLabel.Text = "Пол: мужской";
                else
                    genderLabel.Text = "Пол: женский";
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось получить информацию о пациенте");
                Close();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            //загрузить информацию о пользователе на форму
            InitializeLabels();
        }

        //открыть окно редактирования пользователя
        private void editProfileButton_Click(object sender, EventArgs e)
        {
            EditPatientForm editPatientForm = new EditPatientForm();
            editPatientForm.FormClosed += EditPatientForm_FormClosed;
            editPatientForm.Show();
        }

        //обновление при закрытии формы редактирования профиля
        private void EditPatientForm_FormClosed(object sender, EventArgs e)
        {
            InitializeLabels();
        }

        private void doctorsButton_Click(object sender, EventArgs e)
        {
            DoctorsListForm doctorsListForm = new DoctorsListForm();
            doctorsListForm.Show();
        }
    }
}
