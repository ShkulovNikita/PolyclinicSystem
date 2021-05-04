using System.Text.RegularExpressions;

namespace PolyclinicSystem
{
    static public class Validator
    {
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
    }
}
