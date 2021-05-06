using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Functions
{
    public partial class AddVisitForm : Form
    {
        private List<Doctor> doctors;

        private Doctor chosenDoctor;
        private string chosenDate;

        public AddVisitForm()
        {
            InitializeComponent();
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            messagesLabel.Text = "";

            //установить пределы на даты для записи
            visitDateTimePicker.MinDate = DateTime.Today;
            visitDateTimePicker.MaxDate = DateTime.Today.AddYears(1);

            //заблокировать кнопку записи и выбор даты
            addVisitButton.Enabled = false;
            visitDateTimePicker.Enabled = false;

            //передать список врачей в выпадающий список
            List<Doctor> listDoctors = DataHandler.GetDoctors();
            if (listDoctors != null)
            {
                //сохранение полученного списка врачей
                doctors = listDoctors;

                foreach (Doctor doctor in doctors)
                {
                    doctorsComboBox.Items.Add(doctor.User.Name);
                }
            }
            else
            {
                ErrorHandler.ShowError("Не удалось получить список врачей");
                Close();
            }
        }

        //был выбран доктор
        private void doctorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //разрешить выбрать дату
            visitDateTimePicker.Enabled = true;
            //убедиться, что кнопка без выбора даты заблокирована
            addVisitButton.Enabled = false;
        }

        //выбрана какая-то дата
        private void visitDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            messagesLabel.Text = "";

            //определить, является ли этот день выходным
            string dayOfWeek = visitDateTimePicker.Value.DayOfWeek.ToString();
            if ((dayOfWeek == "Saturday") || (dayOfWeek == "Sunday"))
                messagesLabel.Text = "Выбран нерабочий день";
            else
            {
                dayOfWeek = visitDateTimePicker.Value.ToString("dd.MM.yyyy");

                //получить выбранного доктора
                Doctor chsnDoctor = GetDoctorFromList(doctorsComboBox.SelectedItem.ToString());

                //определить занятость выбранного доктора в выбранный день
                bool dayIsFree = VisitsHandler.CheckDoctorBusyness(chsnDoctor, dayOfWeek);

                //если день свободен, то разрешить записаться на прием
                if (dayIsFree)
                {
                    addVisitButton.Enabled = true;
                    chosenDoctor = chsnDoctor;
                    chosenDate = dayOfWeek;
                }
                else
                    messagesLabel.Text = "Выбранный день занят";
            }
        }

        //получить выбранного доктора по его имени
        private Doctor GetDoctorFromList(string name)
        {
            foreach (Doctor doctor in doctors)
                if (doctor.User.Name == name)
                    return doctor;
            return null;
        }

        //нажатие на кнопку записи на прием
        private void addVisitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (visitTypeComboBox.SelectedItem == null)
                {
                    messagesLabel.Text = "Не выбран тип приема";
                }
                else
                {
                    //добавить новый прием у врача
                    string doctorLogin = chosenDoctor.User.Login;
                    string cardNumber = MainForm.CurPatient.PatientCards[0].CardNumber;
                    string type = visitTypeComboBox.SelectedItem.ToString();
                    DataHandler.AddDoctorVisit(doctorLogin, cardNumber, chosenDate, type);

                    //закрыть окно
                    Close();
                }
            }
            catch(Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось добавить прием");
                Close();
            }
        }
    }
}