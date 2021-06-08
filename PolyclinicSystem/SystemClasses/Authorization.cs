using System;
using PolyclinicSystem.Classes;

namespace PolyclinicSystem
{
    static public class Authorization
    {
        //получение пользователя, в профиль которого осуществляется вход
        static public User SignIn(string login, string password)
        {
            try
            {
                if (IsEmpty(login))
                    ErrorHandler.ShowError("Не введен логин");
                else if (IsEmpty(password))
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

        //смена пароля пользователя
        static public string ChangePassword(string login, string email, string password, string rptPassword)
        {
            try
            {
                //проверки ввода полей
                if (IsEmpty(login))
                    ErrorHandler.ShowError("Не введен логин");
                else if (IsEmpty(email))
                    ErrorHandler.ShowError("Не введена электронная почта");
                else if (IsEmpty(password))
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

        //регистрация
        static public Patient SignUp(string login, string email, string fio, string password,
            string oms, string phone, string address, string gender, string birthdate)
        {
            try
            {
                //проверка заполнения полей
                if (IsEmpty(login))
                    ErrorHandler.ShowError("Не введен логин");
                else if (IsEmpty(password))
                    ErrorHandler.ShowError("Не введен пароль");
                else if (IsEmpty(email))
                    ErrorHandler.ShowError("Не введена электронная почта");
                else if (IsEmpty(fio))
                    ErrorHandler.ShowError("Не введено ФИО");
                else if (IsEmpty(oms))
                    ErrorHandler.ShowError("Не введен ОМС");
                else if (IsEmpty(phone))
                    ErrorHandler.ShowError("Не введен номер телефона");
                else if (IsEmpty(address))
                    ErrorHandler.ShowError("Не введен адрес");
                else if (IsEmpty(gender))
                    ErrorHandler.ShowError("Не выбран пол");
                else if (IsEmpty(birthdate))
                    ErrorHandler.ShowError("Не указана дата рождения");
                else
                {
                    //валидация введенных значений
                    if (!Validator.CheckEmail(email))
                        ErrorHandler.ShowError("Неверный формат электронной почты");
                    else if (!Validator.CheckOMS(oms))
                        ErrorHandler.ShowError("Неверный формат ОМС");
                    else if (!Validator.CheckPhone(phone))
                        ErrorHandler.ShowError("Неверный формат номера телефона");
                    //проверка, есть ли уже пользователь с таким логином
                    else
                    {
                        if (DataHandler.GetPatient(login) != null)
                            ErrorHandler.ShowError("Введенный логин уже занят");
                        //если всё правильно - создание нового пользователя-пациента
                        else
                        {
                            //создание пациента
                            DataHandler.AddPatient(login, fio, email, password, gender, oms, null, birthdate, address, phone);
                            //задание ему карточки
                            string cardNumber = GenerateCardNumber();
                            DataHandler.AddPatientCard(login, cardNumber);

                            return DataHandler.GetPatient(login);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }

            return null;
        }

        //создать номер карточки пациента
        static private string GenerateCardNumber()
        {
            Random rnd = new Random();
            string number = rnd.Next(10).ToString() + rnd.Next(10).ToString() 
                                                    + rnd.Next(10).ToString() + rnd.Next(10).ToString() 
                                                    + rnd.Next(10).ToString();
            return number;
        }

        //определение типа пользователя
        static public string DefineUser(User user)
        {
            if (user.Doctors.Count > 0)
                return "doctor";
            else if (user.Patients.Count > 0)
                return "patient";
            else return "admin";
        }

        //задание текущего пользователя
        static public void SetUser(User user, string usertype)
        {
            try
            {
                if (usertype == "doctor")
                    MainForm.CurDoctor = DataHandler.GetDoctor(user.Login);
                else if (usertype == "patient")
                    MainForm.CurPatient = DataHandler.GetPatient(user.Login);
                else
                    MainForm.CurAdmin = DataHandler.GetAdmin(user.Login);
                MainForm.currentUser = usertype;
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
            }
            
        }

        //убрать текущего пользователя
        static public void LogoutUser()
        {
            MainForm.currentUser = "";
            MainForm.CurAdmin = null;
            MainForm.CurDoctor = null;
            MainForm.CurPatient = null;
        }

        //проверка пустоты значения строки
        static private bool IsEmpty(string value)
        {
            if ((value == "") || (value == null))
                return true;
            return false;
        }
    }
}