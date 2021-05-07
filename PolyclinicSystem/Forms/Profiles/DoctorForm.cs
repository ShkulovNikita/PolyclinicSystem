using System;
using System.Windows.Forms;
using PolyclinicSystem.Forms.Functions;

namespace PolyclinicSystem.Forms
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            InitializeLabels();
        }

        //заполнить поля информацией о враче
        private void InitializeLabels()
        {
            try
            {
                nameLabel.Text = "ФИО: " + MainForm.CurDoctor.User.Name;
                emailLabel.Text = "Email: " + MainForm.CurDoctor.User.Name;
                specialtyLabel.Text = "Специальность: " + MainForm.CurDoctor.Specialty.Name;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось загрузить профиль");
                Close();
            }
        }

        //открыть список приемов
        private void visitsButton_Click(object sender, EventArgs e)
        {
            VisitsListForm visitsForm = new VisitsListForm();
            visitsForm.Show();
        }
    }
}
