using System;
using System.Windows.Forms;
using PolyclinicSystem.Classes;
using PolyclinicSystem.Forms.FeedbackForms;

namespace PolyclinicSystem.Forms.Info
{
    public partial class UserInfoForm : Form
    {
        private User InfoUser;
        private Doctor InfoDoctor;

        public UserInfoForm(User user)
        {
            InitializeComponent();
            InfoUser = user;
        }

        private void UserInfoForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeLabels();
                if (MainForm.CurAdmin != null)
                {
                    //проверить, является ли пользователь доктором
                    InfoDoctor = DataHandler.IsDoctor(InfoUser.Login);

                    if(InfoDoctor != null)
                    {
                        feedbackButton.Visible = true;
                        feedbackButton.Click += ShowFeedbacks_Click;
                    }
                    else
                    {
                        feedbackButton.Visible = false;
                    }
                }
                else
                {
                    feedbackButton.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось загрузить пользователя");
                Close();
            }
        }

        private void InitializeLabels()
        {
            nameLabel.Text = "ФИО: " + InfoUser.Name;
            emailLabel.Text = "Email: " + InfoUser.Email;
            loginLabel.Text = "Логин: " + InfoUser.Login;
            if (InfoUser.Doctors.Count > 0)
                typeLabel.Text = "Тип: доктор";
            else if (InfoUser.Patients.Count > 0)
                typeLabel.Text = "Тип: пациент";
            else
                typeLabel.Text = "Тип: администратор";
        }

        //редактировать пользователя
        private void editButton_Click(object sender, EventArgs e)
        {
            EditUserForm editUserForm = new EditUserForm(InfoUser);
            editUserForm.FormClosed += EditUserForm_FormClosed;
            editUserForm.Show();
        }

        //просмотр списка отзывов
        private void ShowFeedbacks_Click(object sender, EventArgs e)
        {
            FeedbackListForm feedbackListForm = new FeedbackListForm(InfoDoctor);
            feedbackListForm.Show();
        }

        private void EditUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeLabels();
        }
    }
}