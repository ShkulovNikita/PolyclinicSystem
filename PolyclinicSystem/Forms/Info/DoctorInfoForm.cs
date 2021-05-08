using System;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Info
{
    public partial class DoctorInfoForm : Form
    {
        private Doctor InfoDoctor;

        public DoctorInfoForm(Doctor doctor)
        {
            InitializeComponent();
            InfoDoctor = doctor;
        }

        private void DoctorInfoForm_Load(object sender, EventArgs e)
        {
            InitializeLabels();
        }

        //заполнить поля информацией о враче
        private void InitializeLabels()
        {
            try
            {
                nameLabel.Text = "ФИО: " + InfoDoctor.User.Name;
                emailLabel.Text = "Email: " + InfoDoctor.User.Name;
                specialtyLabel.Text = "Специальность: " + InfoDoctor.Specialty.Name;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось загрузить профиль врача");
                Close();
            }
        }
    }
}
