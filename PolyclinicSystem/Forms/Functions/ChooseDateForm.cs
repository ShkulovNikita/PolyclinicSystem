using System;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Functions
{
    public partial class ChooseDateForm : Form
    {
        private Doctor Doctor;
        private string Date;
        private DoctorVisit Visit;

        public ChooseDateForm(Doctor doctor, DoctorVisit visit)
        {
            InitializeComponent();
            Doctor = doctor;
            Visit = visit;
        }

        private void addVisitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //перенести дату приема
                Visit.Move(Date);
                DataHandler.UpdateInDatabase(Visit);
                MessagesHandler.ShowMessage("Прием перенесен");
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось перенести прием");
            }
            Close();
        }

        private void ChooseDateForm_Load(object sender, EventArgs e)
        {
            messagesLabel.Text = "";

            //заблокировать кнопку, пока не выбран день
            chooseDateButton.Enabled = false;

            //установить пределы на даты для записи
            visitDateTimePicker.MinDate = DateTime.Today;
            visitDateTimePicker.MaxDate = DateTime.Today.AddYears(1);
        }

        private void visitDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            messagesLabel.Text = "";

            //определить, является ли этот день выходным
            string dayOfWeek = visitDateTimePicker.Value.DayOfWeek.ToString();
            if ((dayOfWeek == "Saturday") || (dayOfWeek == "Sunday"))
            {
                messagesLabel.Text = "Выбран нерабочий день";
                chooseDateButton.Enabled = false;
            }
            else
            {
                dayOfWeek = visitDateTimePicker.Value.ToString("dd.MM.yyyy");

                //определить занятость выбранного доктора в выбранный день
                bool dayIsFree = VisitsHandler.CheckDoctorBusyness(Doctor, dayOfWeek);

                //если день свободен, то изменить дату приема
                if (dayIsFree)
                {
                    Date = dayOfWeek;
                    chooseDateButton.Enabled = true;
                }
                else
                {
                    messagesLabel.Text = "Выбранный день занят";
                    chooseDateButton.Enabled = false;
                }
            }
        }
    }
}
