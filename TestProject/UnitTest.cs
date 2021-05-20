using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolyclinicSystem;
using System;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
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

            Assert.AreNotEqual(null, user);
        }

        [TestMethod]
        public void TestCheckOMS()
        {
            string[] oms = new string[] { "1234567890123456",
                "123456789012345678",
                "123456789012345",
                "gfskgnnt",
                "gfmntogkflskfjtm",
                "145gfbn64g76g-05"
            };
            bool[] check = new bool[] { true, false, false, false, false, false };
            bool[] results = new bool[6];

            for (int i = 0; i < oms.Length; i++)
                results[i] = Validator.CheckOMS(oms[i]);

            CollectionAssert.AreEqual(check, results);
        }

        [TestMethod]
        public void TestCheckPhone()
        {
            string[] phones = new string[]
            {
                "89521615218",
                "895216152189",
                "8952161521",
                "60945324354",
                "gjdntrtnyty",
                "89fgftrrtrt",
                "fgrtes",
                "13gh56",
                "123456",
                "1234567",
                "12345"
            };

            bool[] check = new bool[] { true, false, false, false, false, 
                                        false, false, false, true, false, false };

            bool[] results = new bool[check.Length];

            for (int i = 0; i < check.Length; i++)
                results[i] = Validator.CheckPhone(phones[i]);

            CollectionAssert.AreEqual(check, results);
        }

        [TestMethod]
        public void TestGetUserByLogin()
        {
            string login = "admin";

            User user = DataHandler.GetUser(login);

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void TestGetVisits()
        {
            List<DoctorVisit> visits = DataHandler.GetVisits();

            Assert.IsNotNull(visits);
        }

        [TestMethod]
        public void TestSignUp()
        {
            Random rand = new Random();
            string randNum = rand.Next().ToString();

            string login = "user" + randNum;
            string email = "user" + randNum + "@yandex.ru";
            string password = "123456";
            string name = "Тестовый Тест Тестович";
            string oms = "1234567890123456";
            string phone = "89001234567";
            string address = "ул. Тестовая, д. 90";
            string gender = "м";
            string birthdate = "01.01.1900";

            Authorization.SignUp(login, email, name, password, oms, phone, address, gender, birthdate);

            Patient patient = DataHandler.GetPatient(login);

            Assert.IsNotNull(patient);
        }
    }
}