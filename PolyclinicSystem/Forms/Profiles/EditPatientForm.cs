using System;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms
{
    public partial class EditPatientForm : Form
    {
        public EditPatientForm()
        {
            InitializeComponent();
        }

        private void EditPatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                //заполнить поля теми значениями, которые уже введены
                omsTextBox.Text = MainForm.CurPatient.OMS;
                addressTextBox.Text = MainForm.CurPatient.Address;
                jobPlaceTextBox.Text = MainForm.CurPatient.JobPlace;
                phoneTextBox.Text = MainForm.CurPatient.Phone;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось получить информацию о профиле");
                Close();
            }
        }

        //подтвердить сохранение введенных изменений
        private void confirmButton_Click(object sender, EventArgs e)
        {
            //получить введенные значения полей
            string oms = omsTextBox.Text;
            string address = addressTextBox.Text;
            string jobPlace = jobPlaceTextBox.Text;
            string phone = phoneTextBox.Text;

            try
            {
                ProfilesHandler.EditPatient(MainForm.CurPatient, oms, jobPlace, phone, address);
                MessagesHandler.ShowMessage("Изменения сохранены");
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