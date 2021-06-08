using System;
using System.Windows.Forms;
using PolyclinicSystem.Classes;

namespace PolyclinicSystem.Forms.Info
{
    public partial class EditUserForm : Form
    {
        private User EditUser;

        public EditUserForm(User user)
        {
            InitializeComponent();
            EditUser = user;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                loginTextBox.Text = EditUser.Login;
                emailTextBox.Text = EditUser.Email;
                nameTextBox.Text = EditUser.Name;
                passwordTextBox.Text = EditUser.Password;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось загрузить пользователя");
                Close();
            }
        }

        //сохранение изменений
        private void confirmButton_Click(object sender, EventArgs e)
        {
            //получить введенные значения полей
            string login = loginTextBox.Text;
            string email = emailTextBox.Text;
            string name = nameTextBox.Text;
            string password = passwordTextBox.Text;

            try
            {
                bool result = ProfilesHandler.EditUser(EditUser, login, email, name, password);
                if (result)
                {
                    MessagesHandler.ShowMessage("Изменения успешно сохранены");
                    Close();
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось сохранить изменения");
                Close();
            }
        }
    }
}
