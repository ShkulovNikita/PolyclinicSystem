using System;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Functions
{
    public partial class AddVisitInfoForm : Form
    {
        private DoctorVisit Visit;

        public AddVisitInfoForm(DoctorVisit visit)
        {
            InitializeComponent();
            Visit = visit;
        }

        private void AddVisitInfoForm_Load(object sender, EventArgs e)
        {
            //если какие-то из полей уже были заполнены - отобразить их значения
            complaintsTextBox.Text = Visit.Complaints;
            diagnosisTextBox.Text = Visit.Diagnosis;
            treatmentTextBox.Text = Visit.Treatment;
        }

        //сохранить изменения
        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                //передать информацию из текстовых полей
                Visit.Complaints = complaintsTextBox.Text;
                Visit.Diagnosis = diagnosisTextBox.Text;
                Visit.Treatment = treatmentTextBox.Text;

                //сохранить
                DataHandler.UpdateInDatabase(Visit);

                MessagesHandler.ShowMessage("Информация сохранена");
                Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось обновить информацию о приеме");
                Close();
            }
        }
    }
}
