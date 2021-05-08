using System;
using System.Data;
using System.Collections.Generic;

namespace PolyclinicSystem
{
    static public class FeedbackHandler
    {
        //получение набора столбцов
        static public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add(new DataColumn("ID", typeof(int)));
                dt.Columns.Add(new DataColumn("Дата", typeof(string)));
                dt.Columns.Add(new DataColumn("ФИО пациента", typeof(string)));
                dt.Columns.Add(new DataColumn("ФИО врача", typeof(string)));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return dt;
        }

        //получить и передать данные о всех врачах
        static public DataTable FillData(Doctor doctor, DataTable dt)
        {
            dt.Rows.Clear();

            try
            {
                List<Feedback> feedbacks = new List<Feedback>();
                feedbacks = doctor.Feedbacks;

                foreach (Feedback feedback in feedbacks)
                {
                    int id = feedback.ID;
                    string date = feedback.Date;
                    string docName = DataHandler.GetDoctor(feedback.DoctorID).User.Name;
                    string patName = DataHandler.GetPatient(feedback.PatientID, true).User.Name;

                    dt.Rows.Add(id, date, patName, docName);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return dt;
        }

        static public bool AddFeedback(Doctor doctor, Patient patient, int value, string text)
        {
            bool result = false;

            if (IsEmpty(text))
                ErrorHandler.ShowError("Не введен текст отзыва");
            else
            {
                try
                {
                    string date = DateTime.Today.ToString("dd.MM.yyyy");
                    DataHandler.AddFeedback(doctor.User.Login, patient.User.Login, value, date, text);
                }
                catch (Exception ex)
                {
                    Logger.WriteLog(ex);
                    ErrorHandler.ShowError("Не удалось сохранить отзыв");
                }
            }

            return result;
        }

        static private bool IsEmpty(string value)
        {
            if ((value == null) || (value == ""))
                return true;
            else return false;
        }
    }
}
