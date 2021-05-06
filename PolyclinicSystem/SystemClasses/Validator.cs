using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PolyclinicSystem
{
    static public class Validator
    {
        static public bool CheckEmail(string email)
        {
            string pattern = @"\w+@\w+\.\w+$";
            return Regex.IsMatch(email, pattern);
        }

        static public bool CheckOMS(string oms)
        {
            string pattern = @"^\d{16}$";
            return Regex.IsMatch(oms, pattern);
        }

        static public bool CheckPhone(string phone)
        {
            string pattern1 = @"^89\d{9}$";
            string pattern2 = @"^\d{6}$";

            return ((Regex.IsMatch(phone, pattern1)) || Regex.IsMatch(phone, pattern2));
        }

        static public bool IsDate(string date)
        {
            string pattern = @"^\d{2}\.\d{2}\.\d{4}$";

            return (Regex.IsMatch(date, pattern));
        }

        static public bool IsSpecialty(string specialty)
        {
            bool result = false;

            List<Specialty> specialties = DataHandler.GetSpecialties();

            foreach (Specialty spec in specialties)
                if (spec.Name == specialty)
                {
                    result = true;
                    break;
                }

            return result;
        }

        static public bool IsStatus(string status)
        {
            if ((status == "Назначен") || (status == "Отменен") || (status == "Перенесен") || (status == "Завершен"))
                return true;
            else return false;
        }
    }
}