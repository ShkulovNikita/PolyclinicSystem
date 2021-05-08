namespace PolyclinicSystem
{
    static public class ProfilesHandler
    {
        static public bool EditUser(User user, string login, string email, string name, string password)
        {
            bool result = false;

            if (IsEmpty(login))
                ErrorHandler.ShowError("Не введен логин");
            else if (IsEmpty(email))
                ErrorHandler.ShowError("Не введена электронная почта");
            else if (IsEmpty(name))
                ErrorHandler.ShowError("Не введено ФИО");
            else if (IsEmpty(password))
                ErrorHandler.ShowError("Не введен пароль");
            else if (!Validator.CheckEmail(email))
                ErrorHandler.ShowError("Неверный формат электронной почты");
            else
            {
                //есть ли уже такой логин
                if (DataHandler.GetPatient(login) != null)
                    ErrorHandler.ShowError("Введенный логин уже занят");
                else
                {
                    user.Edit(name, email, password, login);
                    DataHandler.UpdateInDatabase(user);
                    return true;
                }
            }

            return result;
        }

        static public bool EditPatient(Patient patient, string oms, string jobplace, string phone, string address)
        {
            bool result = false;

            if (IsEmpty(oms))
                ErrorHandler.ShowError("Не введен ОМС");
            else if (IsEmpty(phone))
                ErrorHandler.ShowError("Не введен номер телефона");
            else if (IsEmpty(address))
                ErrorHandler.ShowError("Не введен адрес");
            else if (!Validator.CheckOMS(oms))
                ErrorHandler.ShowError("Неверный формат ОМС");
            else if (!Validator.CheckPhone(phone))
                ErrorHandler.ShowError("Неверный формат номера телефона");
            else
            {
                patient.Edit(oms, jobplace, address, phone);
                DataHandler.UpdateInDatabase(patient);
                return true;
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
