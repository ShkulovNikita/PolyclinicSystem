﻿using System;
using System.Windows.Forms;

namespace PolyclinicSystem.Forms.Functions
{
    public partial class VisitForm : Form
    {
        public DoctorVisit Visit;

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
            writeInfoButton.Visible = false;
            endVisitButton.Visible = false;
        }

        private void InitializeLabels()
        {
            try
            {
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
    }
}
