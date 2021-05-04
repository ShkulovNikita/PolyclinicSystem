using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace PolyclinicSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Logger.ActivateLogger();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection db = new SQLiteConnection("Polyclinic.db"))
                {
                    
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        //нажатие на кнопку входа в профиль
        private void signInButton_Click(object sender, EventArgs e)
        {
            try
            {
                User user = Authorization.SignIn(loginTextBox.Text, passwordTextBox.Text);
                if (user != null)
                {
                    loginTextBox.Text = "Вход выполнен: " + user.Name;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        //нажатие на кнопку регистрации
        private void signUpButton_Click(object sender, EventArgs e)
        {

        }

        //восстановление пароля
        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
