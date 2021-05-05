using System;
using System.Windows.Forms;
using PolyclinicSystem.Forms;
using SQLite;

namespace PolyclinicSystem
{
    public partial class MainForm : Form
    {
        static public Patient CurPatient;
        static public Doctor CurDoctor;
        static public Administrator CurAdmin;

        static public string currentUser = "";

        public MainForm()
        {
            InitializeComponent();
            Logger.ActivateLogger();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loginTextBox.Text = "domin";
            passwordTextBox.Text = "123456";

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
                    //определить, кем является пользователь
                    string userType = Authorization.DefineUser(user);
                    //установить текущего пользователя
                    Authorization.SetUser(user, userType);
                    //переход к соответствующему профилю
                    if (userType == "patient")
                    {
                        PatientForm patientForm = new PatientForm();
                        patientForm.FormClosed += UserForm_FormClosed;
                        patientForm.Show();
                    }
                    else if (userType == "doctor")
                    {
                        DoctorForm doctorForm = new DoctorForm();
                        doctorForm.FormClosed += UserForm_FormClosed;
                        doctorForm.Show();
                    }
                    else if (userType == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.FormClosed += UserForm_FormClosed;
                        adminForm.Show();
                    }
                    Visible = false;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }
        }

        //нажатие на кнопку регистрации
        private void signUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.FormClosed += SignUpForm_FormClosed;
                signUpForm.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }
        }

        //восстановление пароля
        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            try
            {
                ForgotPasswordForm form = new ForgotPasswordForm();
                form.FormClosed += ForgotPasswordForm_FormClosed;
                form.Show();
                Visible = false;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }
        }

        //отреагировать на закрытие формы смены пароля
        private void ForgotPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        //отреагировать на закрытие формы регистрации
        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = true;
        }

        //закрытие форм пользователей ведет к выходу из приложения
        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Authorization.LogoutUser();
            Close();
        }

    }
}