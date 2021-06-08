using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using PolyclinicSystem.Classes;

namespace PolyclinicSystem
{
    public static class DoctorsHandler
    {
        //получение набора столбцов
        static public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add(new DataColumn("ID", typeof(int)));
                dt.Columns.Add(new DataColumn("Специальность", typeof(string)));
                dt.Columns.Add(new DataColumn("ФИО", typeof(string)));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return dt;
        }

        //получить и передать данные о всех врачах
        static public DataTable FillData(DataTable dt)
        {
            dt.Rows.Clear();

            try
            {
                List<Doctor> doctors;
                doctors = DataHandler.GetDoctors();
                
                foreach(Doctor doctor in doctors)
                {
                    int id = doctor.DoctorID;
                    string name = doctor.User.Name;
                    string specialty = doctor.Specialty.Name;

                    dt.Rows.Add(id, specialty, name);
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
        static public DataTable Search(string query, DataTable dt)
        {
            //пустой запрос сбрасывает поиск
            if ((query == "") || (query == null))
                return FillData(dt);

            //получить отдельные части запроса
            string[] queryParts = query.Split(',');

            foreach (string qry in queryParts)
            {
                if (Validator.IsSpecialty(qry))
                    dt = FilterData(dt, "Специальность", qry);
                else dt = FilterData(dt, "ФИО", qry);
            }

            return dt;
        }

        //фильтрация данных на основе поискового запроса
        static private DataTable FilterData(DataTable table, string field, string value)
        {
            try
            {
                table = table.AsEnumerable()
                .Where(row => row.Field<string>(field) == value)
                .CopyToDataTable();
                return table;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                DataTable dt = table.Clone();
                return dt;
            }
        }
    }
}