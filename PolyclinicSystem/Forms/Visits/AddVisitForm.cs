using System;
using System.Windows.Forms;
using PolyclinicSystem.Classes;

namespace PolyclinicSystem.Forms.Functions
{
    public partial class AddVisitForm : Form
    {
        private Doctor chosenDoctor;
        private string chosenDate;

        public AddVisitForm(Doctor doctor)
        {
            InitializeComponent();
            chosenDoctor = doctor;
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {
            messagesLabel.Text = "";

            //установить пределы на даты для записи
            visitDateTimePicker.MinDate = DateTime.Today;
            visitDateTimePicker.MaxDate = DateTime.Today.AddYears(1);

            //заблокировать кнопку записи и выбор даты
            addVisitButton.Enabled = false;

            //указать выбранного врача
            doctorTextBox.Text = chosenDoctor.User.Name;
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

                //определить занятость выбранного доктора в выбранный день
                bool dayIsFree = VisitsHandler.CheckDoctorBusyness(chosenDoctor, dayOfWeek);

                //если день свободен, то разрешить записаться на прием
                if (dayIsFree)
                {
                    addVisitButton.Enabled = true;
                    chosenDate = dayOfWeek;
                }
                else
                    messagesLabel.Text = "Выбранный день занят";
            }
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

                    MessagesHandler.ShowMessage("Записан новый прием у врача");

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