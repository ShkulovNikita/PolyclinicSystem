using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PolyclinicSystem
{
    public static class UsersHandler
    {
        //получение набора столбцов таблицы пользователей
        static public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            try
            {
                dt.Columns.Add(new DataColumn("ID", typeof(int)));
                dt.Columns.Add(new DataColumn("Тип", typeof(string)));
                dt.Columns.Add(new DataColumn("ФИО", typeof(string)));
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return dt;
        }

        //получить и передать данные о всех пользователях
        static public DataTable FillData(DataTable dt)
        {
            dt.Rows.Clear();

            try
            {
                List<User> users;
                users = DataHandler.GetUsers();

                foreach (User user in users) 
                {
                    int id = user.ID;
                    string name = user.Name;
                    string type = "";
                    if (user.Patients.Count > 0)
                        type = "Пациент";
                    else if (user.Doctors.Count > 0)
                        type = "Доктор";
                    else type = "Администратор";

                    dt.Rows.Add(id, type, name);
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

            foreach(string qry in queryParts)
            {
                if (Validator.IsType(qry))
                    dt = FilterData(dt, "Тип", qry);
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
