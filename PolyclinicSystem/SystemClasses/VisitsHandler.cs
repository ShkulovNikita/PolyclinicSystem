using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
                        dt.Columns.Add(new DataColumn("ID", typeof(int)));
                        dt.Columns.Add(new DataColumn("Дата приема", typeof(string)));
                        dt.Columns.Add(new DataColumn("Статус", typeof(string)));
                        dt.Columns.Add(new DataColumn("Специалист", typeof(string)));
                        dt.Columns.Add(new DataColumn("ФИО врача", typeof(string)));
                        break;
                    case "doctor":
                        dt.Columns.Add(new DataColumn("ID", typeof(int)));
                        dt.Columns.Add(new DataColumn("Дата приема", typeof(string)));
                        dt.Columns.Add(new DataColumn("Статус", typeof(string)));
                        dt.Columns.Add(new DataColumn("ФИО пациента", typeof(string)));
                        break;
                    case "admin":
                        dt.Columns.Add(new DataColumn("ID", typeof(int)));
                        dt.Columns.Add(new DataColumn("Дата приема", typeof(string)));
                        dt.Columns.Add(new DataColumn("Статус", typeof(string)));
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
                            //статус приема
                            string status = visit.Status;
                            //ФИО врача
                            string name = DataHandler.GetDoctor(visit.DoctorID).User.Name;

                            //добавить соответствующую строку в таблицу
                            dt.Rows.Add(visit.VisitID, date, status, specialty, name);
                        }
                        break;
                    case "doctor":
                        visits = DataHandler.GetVisitsByDoctor(MainForm.CurDoctor.DoctorID);
                        foreach (DoctorVisit visit in visits)
                        {
                            //дата посещения
                            string date = visit.Date;
                            //статус приема
                            string status = visit.Status;
                            //ФИО пациента
                            string name = DataHandler.GetPatient(visit.PatientCardID).User.Name;

                            //добавить строку в таблицу
                            dt.Rows.Add(visit.VisitID, date, status, name);
                        }
                        break;
                    case "admin":
                        visits = DataHandler.GetVisits();
                        foreach (DoctorVisit visit in visits)
                        {
                            //дата посещения
                            string date = visit.Date;
                            //статус приема
                            string status = visit.Status;
                            //ФИО пациента
                            string patName = DataHandler.GetPatient(visit.PatientCardID).User.Name;
                            //ФИО врача
                            string docName = DataHandler.GetDoctor(visit.DoctorID).User.Name;

                            //добавить в таблицу
                            dt.Rows.Add(visit.VisitID, date, status, patName, docName);
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

        //выполнение поиска
        static public DataTable Search(string usertype, string query, DataTable dt)
        {
            //пустой запрос сбрасывает поиск
            if ((query == "") || (query == null))
                return FillData(usertype, dt);

            //получить отдельные части запроса
            string[] queryParts = query.Split(',');

            switch (usertype)
            {
                case "patient":
                    foreach(string qry in queryParts)
                    {
                        if(Validator.IsDate(qry))
                            dt = FilterData(dt, "Дата приема", qry);
                        else if (Validator.IsSpecialty(qry))
                            dt = FilterData(dt, "Специалист", qry);
                        else if (Validator.IsStatus(qry))
                            dt = FilterData(dt, "Статус", qry);
                        else
                            dt = FilterData(dt, "ФИО врача", qry);
                    }
                    break;
                case "doctor":
                    foreach (string qry in queryParts)
                    {
                        if (Validator.IsDate(qry)) 
                            dt = FilterData(dt, "Дата приема", qry);
                        else if (Validator.IsSpecialty(qry))
                            dt = FilterData(dt, "Специалист", qry);
                        else if (Validator.IsStatus(qry))
                            dt = FilterData(dt, "Статус", qry);
                        else
                            dt = FilterData(dt, "ФИО пациента", qry);
                    }
                    break;
                case "admin":
                    foreach (string qry in queryParts)
                    {
                        if (Validator.IsDate(qry))
                            dt = FilterData(dt, "Дата приема", qry);
                        else if (Validator.IsStatus(qry))
                            dt = FilterData(dt, "Статус", qry);
                        else
                        {
                            DataTable dt1 = FilterData(dt, "ФИО пациента", qry);
                            DataTable dt2 = FilterData(dt, "ФИО врача", qry);
                            dt = dt1.AsEnumerable()
                                .Union(dt2.AsEnumerable())
                                .Distinct()
                                .CopyToDataTable();
                        }
                    }
                    break;
            }

            return dt;
        }

        //фильтрация данных на основе поискового запроса
        static private DataTable FilterData(DataTable table, string field, string value)
        {
            table = table.AsEnumerable()
                .Where(row => row.Field<string>(field) == value)
                .CopyToDataTable();
            return table;
        }
    }
}