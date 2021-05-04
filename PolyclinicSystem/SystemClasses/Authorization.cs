using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyclinicSystem
{
    static public class Authorization
    {
        static public User SignIn(string login, string password)
        {
            try
            {
                if ((login == "") || (login == null))
                    ErrorHandler.ShowError("Не введен логин");
                else if ((password == "") || (password == null))
                    ErrorHandler.ShowError("Не введен пароль");
                else
                {
                    //попытка получить пользователя с введенным логином
                    User user = DataHandler.GetUser(login);
                    if (user == null)
                        ErrorHandler.ShowError("Пользователь с введенным логином не найден");
                    //проверка введенного пароля
                    else if (password != user.Password)
                        ErrorHandler.ShowError("Введен неверный пароль");
                    //если все правильно, то вернуть полученного пользователя
                    else return user;
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return null;
        }

    }
}
