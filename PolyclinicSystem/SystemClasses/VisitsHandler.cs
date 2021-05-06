using System;
using System.Collections.Generic;
using System.Data;

namespace PolyclinicSystem
{
    public static class VisitsHandler
    {
        //получение набора столбцов таблицы приемов для текущего пользователя
        static public DataTable GetDataTable(string usertype)
        {
            DataTable dt = new DataTable();

            try
            {
                //определение текущего пользователя
                //каждый имеет свой набор столбцов в таблице
                switch (usertype)
                {
                    case "patient":
                        dt.Columns.Add(new DataColumn("Дата приема", typeof(string)));
                        dt.Columns.Add(new DataColumn("Специалист", typeof(string)));
                        dt.Columns.Add(new DataColumn("ФИО врача", typeof(string)));
                        break;
                    case "doctor":
                        dt.Columns.Add(new DataColumn("Дата приема", typeof(string)));
                        dt.Columns.Add(new DataColumn("ФИО пациента", typeof(string)));
                        break;
                    case "admin":
                        dt.Columns.Add(new DataColumn("Дата приема", typeof(string)));
                        dt.Columns.Add(new DataColumn("ФИО пациента", typeof(string)));
                        dt.Columns.Add(new DataColumn("ФИО врача", typeof(string)));
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return dt;
        }

        //получить и передать данные о всех посещениях
        static public DataTable FillData(string usertype, DataTable dt)
        {
            dt.Rows.Clear();

            try
            {
                List<DoctorVisit> visits;
                switch(usertype)
                {
                    case "patient":
                        visits = DataHandler.GetVisitsByPatient(MainForm.CurPatient.PatientID);
                        foreach (DoctorVisit visit in visits)
                        {
                            //дата посещения
                            string date = visit.Date;
                            //специальность врача
                            string specialty = DataHandler.GetSpecialtyByDoctor(visit.DoctorID).Name;
                            //ФИО врача
                            string name = DataHandler.GetDoctor(visit.DoctorID).User.Name;

                            //добавить соответствующую строку в таблицу
                            dt.Rows.Add(date, specialty, name);
                        }
                        break;
                    case "doctor":
                        visits = DataHandler.GetVisitsByDoctor(MainForm.CurDoctor.DoctorID);
                        foreach (DoctorVisit visit in visits)
                        {
                            //дата посещения
                            string date = visit.Date;
                            //ФИО пациента
                            string name = DataHandler.GetPatient(visit.PatientCardID).User.Name;

                            //добавить строку в таблицу
                            dt.Rows.Add(date, name);
                        }
                        break;
                    case "admin":
                        visits = DataHandler.GetVisits();
                        foreach (DoctorVisit visit in visits)
                        {
                            //дата посещения
                            string date = visit.Date;
                            //ФИО пациента
                            string patName = DataHandler.GetPatient(visit.PatientCardID).User.Name;
                            //ФИО врача
                            string docName = DataHandler.GetDoctor(visit.DoctorID).User.Name;

                            //добавить в таблицу
                            dt.Rows.Add(date, patName, docName);
                        }
                        break;
                }

                return dt;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }

        //записаться на прием текущему пациенту
        static public string AddVisit(string date, string doctorLogin, Patient patient)
        {
            try
            {
                PatientCard card = DataHandler.GetPatientCardByPatient(patient.PatientID);
                DataHandler.AddDoctorVisit(doctorLogin, card.CardNumber, date);
                return "записан";
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return "ошибка";
            }
        }
    }
}