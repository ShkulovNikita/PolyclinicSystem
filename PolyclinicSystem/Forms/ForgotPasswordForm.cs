using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        //выполнить смену пароля
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            //попытка изменения пароля
            string attempt = Authorization.ChangePassword(loginTextBox.Text, emailTextBox.Text, passwordTextBox.Text, repeatPasswTextBox.Text);
            if (attempt == "Пароль изменен")
            {
                //показать сообщение, что смена прошла успешно
                MessagesHandler.ShowMessage("Пароль успешно изменен");
                //закрыть форму
                Close();
            }
        }
    }
}
