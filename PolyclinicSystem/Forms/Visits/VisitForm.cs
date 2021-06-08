using PolyclinicSystem.Forms.Info;
using System;
using System.Drawing;
using System.Windows.Forms;
using PolyclinicSystem.Classes;

namespace PolyclinicSystem.Forms.Functions
{
    public partial class VisitForm : Form
    {
        private DoctorVisit Visit;

        public VisitForm(DoctorVisit visit)
        {
            InitializeComponent();
            Visit = visit;
        }

        private void VisitForm_Load(object sender, EventArgs e)
        {
            //вывести информацию о приеме на форму
            InitializeLabels();
            //если текущий пользователь - не врач, то скрыть кнопки для записи информации
            if (MainForm.CurDoctor == null)
            {
                writeInfoButton.Visible = false;
                endVisitButton.Visible = false;
            }
            //если зашел администратор - заблокировать кнопки
            if (MainForm.CurAdmin != null)
            {
                moveButton.Enabled = false;
                cancelButton.Enabled = false;
            }
            //если прием отменен или завершен, то отключить все кнопки
            if((Visit.Status == "Отменен") || (Visit.Status == "Завершен"))
            {
                BlockButtons();
            }
            //если текущий пользователь - врач, то разрешить просмотреть профиль пациента
            if (MainForm.CurDoctor != null)
            {
                patientLabel.Click += PatientLabel_Click;
                patientLabel.ForeColor = Color.Blue;
            }
            //если текущий пользователь - пациент, то разрешить просмотреть профиль врача
            if (MainForm.CurPatient != null)
            {
                doctorLabel.Click += DoctorLabel_Click;
                doctorLabel.ForeColor = Color.Blue;
            }
            //если администратор - разрешить просмотр и врача, и пациента
            if (MainForm.CurAdmin != null)
            {
                patientLabel.Click += PatientLabel_Click;
                patientLabel.ForeColor = Color.Blue;

                doctorLabel.Click += DoctorLabel_Click;
                doctorLabel.ForeColor = Color.Blue;
            }
        }

        private void PatientLabel_Click(object sender, EventArgs e)
        {
            //получить пациента
            Patient patient = DataHandler.GetPatient(Visit.PatientCardID);
            //открыть его профиль
            PatientInfoForm patientInfoForm = new PatientInfoForm(patient);
            patientInfoForm.Show();
        }

        private void DoctorLabel_Click(object sender, EventArgs e)
        {
            //получить врача
            Doctor doctor = DataHandler.GetDoctor(Visit.DoctorID);
            //открыть его профиль
            DoctorInfoForm doctorInfoForm = new DoctorInfoForm(doctor);
            doctorInfoForm.Show();
        }

        private void InitializeLabels()
        {
            try
            {
                Visit = DataHandler.GetDoctorVisit(Visit.VisitID);

                dateLabel.Text = "Дата: " + Visit.Date;
                statusLabel.Text = "Статус: " + Visit.Status;
                typeLabel.Text = "Тип: " + Visit.Type;

                Doctor doctor = DataHandler.GetDoctor(Visit.DoctorID);
                doctorLabel.Text = "Доктор: " + doctor.User.Name;

                Patient patient = DataHandler.GetPatient(Visit.PatientCardID);
                patientLabel.Text = "Пациент: " + patient.User.Name;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                ErrorHandler.ShowError("Не удалось загрузить информацию о приеме");
                Close();
            }
        }

        //просмотр информации о жалобах
        private void complaintsLabel_Click(object sender, EventArgs e)
        {
            if ((Visit.Complaints != null) && (Visit.Complaints != ""))
            {
                VisitInfoForm visitInfoForm = new VisitInfoForm("Жалобы", Visit.Complaints);
                visitInfoForm.Show();
            }
            else
                MessagesHandler.ShowMessage("Информация не введена");
        }

        //просмотр информации о диагнозе
        private void diagnosisLabel_Click(object sender, EventArgs e)
        {
            if ((Visit.Diagnosis != null) && (Visit.Diagnosis != ""))
            {
                VisitInfoForm visitInfoForm = new VisitInfoForm("Диагноз", Visit.Diagnosis);
                visitInfoForm.Show();
            }
            else
                MessagesHandler.ShowMessage("Информация не введена");
        }

        //просмотр информации о лечении
        private void treatmentLabel_Click(object sender, EventArgs e)
        {
            if ((Visit.Treatment != null) && (Visit.Treatment != ""))
            {
                VisitInfoForm visitInfoForm = new VisitInfoForm("Лечение", Visit.Treatment);
                visitInfoForm.Show();
            }
            else
                MessagesHandler.ShowMessage("Информация не введена");
        }

        //перенос на другую дату
        private void moveButton_Click(object sender, EventArgs e)
        {
            Doctor doctor = DataHandler.GetDoctor(Visit.DoctorID);
            ChooseDateForm chooseDateForm = new ChooseDateForm(doctor, Visit);
            chooseDateForm.FormClosed += ChooseDateForm_FormClosed;
            chooseDateForm.Show();
        }

        //закрытие формы выбора даты
        private void ChooseDateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //обновить информацию о приеме
            InitializeLabels();
        }

        //отменить прием у врача
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //спросить подтверждение
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите отменить прием?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Visit.Cancel();
                DataHandler.UpdateInDatabase(Visit);
                InitializeLabels();
                BlockButtons();
            }
        }

        private void BlockButtons()
        {
            writeInfoButton.Enabled = false;
            endVisitButton.Enabled = false;
            moveButton.Enabled = false;
            cancelButton.Enabled = false;
        }

        //отметить прием как завершенный
        private void endVisitButton_Click(object sender, EventArgs e)
        {
            //спросить подтверждение
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите завершить прием?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Visit.Complete();
                DataHandler.UpdateInDatabase(Visit);
                InitializeLabels();
                BlockButtons();
            }
        }

        //запись результатов приема
        private void writeInfoButton_Click(object sender, EventArgs e)
        {
            AddVisitInfoForm addInfoForm = new AddVisitInfoForm(Visit);
            addInfoForm.FormClosed += AddVisitInfoForm_FormClosed;
            addInfoForm.Show();
        }

        private void AddVisitInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitializeLabels();
        }
    }
}