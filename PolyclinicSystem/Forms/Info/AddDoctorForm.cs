using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Info
{
    public partial class AddDoctorForm : Form
    {
        public AddDoctorForm()
        {
            InitializeComponent();
        }

        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            try
            {
                //передать все специальности в выпадающий список
                List<Specialty> specialties = new List<Specialty>();
                specialties = DataHandler.GetSpecialties();
                foreach (Specialty specialty in specialties)
                    specialtyComboBox.Items.Add(specialty.Name);
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Произошла ошибка");
                Close();
            }
        }

        //сохранить нового врача
        private void confirmButton_Click(object sender, EventArgs e)
        {
            //получить введенные значения
            if (specialtyComboBox.SelectedItem == null)
                ErrorHandler.ShowError("Не выбрана специальность");
            else
            {
                string specialty = specialtyComboBox.SelectedItem.ToString();
                string login = loginTextBox.Text;
                string password = passwordTextBox.Text;
                string name = nameTextBox.Text;
                string email = emailTextBox.Text;

                try
                {
                    bool result = ProfilesHandler.AddDoctor(login, name, email, password, specialty);
                    if (result) 
                    {
                        MessagesHandler.ShowMessage("Добавлен новый врач");
                        Close();
                    }
                }
                catch(Exception ex)
                {
                    Logger.WriteLog(ex);
                    ErrorHandler.ShowError("Не удалось сохранить нового врача");
                    Close();
                }
            }
        }
    }
}