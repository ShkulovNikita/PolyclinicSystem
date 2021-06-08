using System;
using System.Windows.Forms;
using PolyclinicSystem.Classes;

namespace PolyclinicSystem.Forms.FeedbackForms
{
    public partial class AddFeedbackForm : Form
    {
        private Doctor Doctor;
        private Patient Patient;

        public AddFeedbackForm(Doctor doctor, Patient patient)
        {
            InitializeComponent();
            Doctor = doctor;
            Patient = patient;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //получение значений
            int value = 0;
            if (radioButton1.Checked)
                value = 1;
            else if (radioButton2.Checked)
                value = 2;
            else if (radioButton3.Checked)
                value = 3;
            else if (radioButton4.Checked)
                value = 4;
            else if (radioButton5.Checked)
                value = 5;

            if (value == 0)
                ErrorHandler.ShowError("Не выбрана оценка");
            else
            {
                string text = textBox.Text;
                try
                {
                    bool result = FeedbackHandler.AddFeedback(Doctor, Patient, value, text);
                    if (result)
                    {
                        MessagesHandler.ShowMessage("Отзыв успешно сохранен");
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(ex);
                    Close();
                }
            }
        }
    }
}
