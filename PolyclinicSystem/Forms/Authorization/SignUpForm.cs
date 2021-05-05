using System;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            birthdateTimePicker.MaxDate = DateTime.Today;
        }

        static public Patient registeredPatient;

        //кнопка выполнения регистрации
        private void signUpButton_Click(object sender, EventArgs e)
        {
            //получение выбранных значений

            //пола
            string gender = "";
            if (maleRadioButton.Checked)
                gender = "м";
            else if (femaleRadioButton.Checked)
                gender = "ж";
            else
                gender = null;

            //даты рождения
            string birthdate = birthdateTimePicker.Value.ToString("dd.MM.yyyy");

            //попытка регистрации нового пользователя-пациента
            Patient patient = Authorization.SignUp(loginTextBox.Text, emailTextBox.Text,
                fioTextBox.Text, passwordTextBox.Text, omsTextBox.Text, phoneTextBox.Text,
                addressTextBox.Text, gender, birthdate);

            //если регистрация прошла успешно
            if (patient != null)
            {
                //проинформировать пользователя
                MessagesHandler.ShowMessage("Регистрация прошла успешно");
                //закрыть текущую форму
                Close();
            }
        }

    }
}
