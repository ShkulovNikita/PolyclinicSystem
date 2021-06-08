using System;
using System.Windows.Forms;
using PolyclinicSystem.Classes;

namespace PolyclinicSystem.Forms
{
    public partial class PatientInfoForm : Form
    {
        private Patient InfoPatient;

        public PatientInfoForm(Patient patient)
        {
            InitializeComponent();
            InfoPatient = patient;
        }

        private void PatientInfoForm_Load(object sender, EventArgs e)
        {
            InitializeLabels();
        }

        private void InitializeLabels()
        {
            try
            {
                nameLabel.Text = "ФИО: " + InfoPatient.User.Name;
                omsLabel.Text = "ОМС: " + InfoPatient.OMS;
                phoneLabel.Text = "Телефон: " + InfoPatient.Phone;
                jobPlaceLabel.Text = "Место работы/учебы: " + InfoPatient.JobPlace;
                addressLabel.Text = "Адрес:\n" + InfoPatient.Address;
                birthdateLabel.Text = "Дата рождения: " + InfoPatient.BirthDate;

                if (InfoPatient.Gender == "м")
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
    }
}
