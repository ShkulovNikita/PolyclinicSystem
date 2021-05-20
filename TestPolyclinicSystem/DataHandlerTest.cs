using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolyclinicSystem;
using System;

namespace TestPolyclinicSystem
{
    [TestClass]
    public class DataHandlerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestAddUser()
        {
            //создать случайного тестового пользователя
            Random rand = new Random();
            string numb = rand.Next().ToString();

            string login = "user_login" + numb;
            string email = "user" + numb + "@mail.ru";
            string password = "test_password";
            string name = "Тестовый Тест Тестович";

            //добавить пользователя в БД
            DataHandler.AddUser(login, name, email, password);

            //проверить существование добавленного пользователя
            User user = DataHandler.GetUser(login);

            Assert.AreNotEqual(user, null);
        }

        [TestMethod]
        public void TestGetUser()
        {
            string login = "admin";

            User user = DataHandler.GetUser(login);

            Assert.AreNotEqual(user, null);
        }
    }
}
