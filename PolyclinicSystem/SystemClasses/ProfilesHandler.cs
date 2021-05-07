namespace PolyclinicSystem
{
    static public class ProfilesHandler
    {
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
