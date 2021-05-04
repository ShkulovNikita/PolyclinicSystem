using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyclinicSystem
{
    static public class Authorization
    {
        //получение пользователя, в профиль которого осуществляется вход
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

        static public string ChangePassword(string login, string email, string password, string rptPassword)
        {
            try
            {
                //проверки ввода полей
                if ((login == "") || (login == null))
                    ErrorHandler.ShowError("Не введен логин");
                else if ((email == "") || (email == null))
                    ErrorHandler.ShowError("Не введена электронная почта");
                else if ((password == "") || (password == null))
                    ErrorHandler.ShowError("Не введен пароль");
                else if (password != rptPassword)
                    ErrorHandler.ShowError("Пароли не совпадают");
                else
                {
                    //проверка существования пользователя с указанным логином
                    User user = DataHandler.GetUser(login);
                    if (user == null)
                        ErrorHandler.ShowError("Пользователь с введенным логином не найден");
                    //проверка совпадения почтового ящика
                    else if (email != user.Email)
                        ErrorHandler.ShowError("Неверно введена электронная почта");
                    //всё введено правильно
                    else
                    {
                        //изменить пароль пользователя
                        user.ChangePassword(password);
                        //сохранить изменения в базе данных
                        DataHandler.UpdateInDatabase(user);
                        //указать форме, что всё прошло успешно
                        return "Пароль изменен";
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return "Ошибка";
            }

            return "Ошибка";
        }

    }
}
