using System;
using System.Windows.Forms;
using PolyclinicSystem.Forms.Functions;

namespace PolyclinicSystem.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void InitializeLabels()
        {
            try
            {
                nameLabel.Text = "ФИО: " + MainForm.CurAdmin.User.Name;
                emailLabel.Text = "Email: " + MainForm.CurAdmin.User.Email;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось загрузить профиль");
                Close();
            }
        }

        private void visitsButton_Click(object sender, EventArgs e)
        {
            VisitsListForm visitsForm = new VisitsListForm();
            visitsForm.Show();
        }

        private void usersListButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            InitializeLabels();
        }
    }
}
