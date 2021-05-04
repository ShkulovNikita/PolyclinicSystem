using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;

namespace PolyclinicSystem
{
    static public class DataHandler
    {
        static readonly string DBFile = "Polyclinic.db";

        static private void AddToDatabase(object obj)
        {
            try
            {
                using (SQLiteConnection db = new SQLiteConnection(DBFile))
                {
                    db.Insert(obj);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static private void UpdateInDatabase(object obj)
        {
            try
            {
                using (SQLiteConnection db = new SQLiteConnection(DBFile))
                {
                    db.UpdateWithChildren(obj);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddUser(string login, string name, string email, string password)
        {
            try
            {
                User user = new User
                {
                    Login = login,
                    Name = name,
                    Email = email,
                    Password = password
                };

                AddToDatabase(user);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddSpecialty(string name)
        {
            try
            {
                Specialty specialty = new Specialty
                {
                    Name = name
                };

                AddToDatabase(specialty);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddAdministrator(string login, string name, string email, string password, string phone)
        {
            try
            {
                //сначала - создание пользователя для администратора
                User user = new User
                {
                    Login = login,
                    Name = name,
                    Email = email,
                    Password = password
                };
                AddToDatabase(user);

                //затем - создание администратора
                Administrator admin = new Administrator
                {
                    Phone = phone
                };
                AddToDatabase(admin);

                user.Administrators = new List<Administrator> { admin };
                UpdateInDatabase(user);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddPatient(string login, string name, string email, string password, 
            string gender, string oms, string jobplace, string birthdate, string address, string phone)
        {
            try
            {
                //сначала создать пользователя для пациента
                User user = new User
                {
                    Login = login,
                    Name = name,
                    Email = email,
                    Password = password
                };
                AddToDatabase(user);

                //затем самого пациента
                Patient patient = new Patient
                {
                    Gender = gender,
                    OMS = oms,
                    JobPlace = jobplace,
                    BirthDate = birthdate,
                    Address = address,
                    Phone = phone
                };
                AddToDatabase(patient);

                //установить зависимость
                user.Patients = new List<Patient> { patient };
                UpdateInDatabase(user);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddDoctor(string login, string name, string email, string password, string specialty)
        {
            try
            {
                //создание пользователя для врача
                User user = new User
                {
                    Login = login,
                    Name = name,
                    Email = email,
                    Password = password
                };
                AddToDatabase(user);

                //создание врача
                Doctor doctor = new Doctor { };
                AddToDatabase(doctor);

                //привязка доктора к пользователю
                user.Doctors = new List<Doctor> { doctor };
                UpdateInDatabase(user);

                //привязка специальности к доктору
                Specialty spec = GetSpecialty(specialty);
                if (spec.Doctors.Count == 0)
                    spec.Doctors = new List<Doctor> { doctor };
                else
                    spec.Doctors.Add(doctor);

                UpdateInDatabase(spec);
            }            
            catch(Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddPatientCard(string login, string number)
        {
            try 
            {
                //создать карту пациента
                PatientCard card = new PatientCard {
                    CardNumber = number
                };
                AddToDatabase(card);

                //привязать карту к пациенту
                Patient patient = GetPatient(login);
                if (patient.PatientCards.Count == 0)
                    patient.PatientCards = new List<PatientCard> { card };
                else
                    patient.PatientCards.Add(card);
                UpdateInDatabase(patient);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddDoctorVisit(string doctorLogin, string cardNumber, string date)
        {
            try
            {
                //создать новый прием
                DoctorVisit visit = new DoctorVisit
                {
                    Date = date,
                    Status = "Назначен"
                };
                AddToDatabase(visit);

                //привязать прием к пациенту
                PatientCard card = GetPatientCard(cardNumber);
                if (card.DoctorVisits.Count == 0)
                    card.DoctorVisits = new List<DoctorVisit> { visit };
                else
                    card.DoctorVisits.Add(visit);
                UpdateInDatabase(card);

                //привязать прием к врачу
                Doctor doctor = GetDoctor(doctorLogin);
                if (doctor.DoctorVisits.Count == 0)
                    doctor.DoctorVisits = new List<DoctorVisit> { visit };
                else
                    doctor.DoctorVisits.Add(visit);
                UpdateInDatabase(doctor);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public void AddFeedback(string doctorLogin, string patientLogin, int rating, string date, string text)
        {
            try
            {
                //создать новый отзыв
                Feedback feedback = new Feedback
                {
                    Rating = rating,
                    Date = date,
                    Text = text
                };
                AddToDatabase(feedback);

                //привязать к доктору
                Doctor doctor = GetDoctor(doctorLogin);
                if (doctor.Feedbacks.Count == 0)
                    doctor.Feedbacks = new List<Feedback> { feedback };
                else
                    doctor.Feedbacks.Add(feedback);
                UpdateInDatabase(doctor);

                //привязать к пациенту
                Patient patient = GetPatient(patientLogin);
                if (patient.Feedbacks.Count == 0)
                    patient.Feedbacks = new List<Feedback> { feedback };
                else
                    patient.Feedbacks.Add(feedback);
                UpdateInDatabase(patient);
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
            }
        }

        static public User GetUser(string login)
        {
            try
            {
                using(SQLiteConnection db = new SQLiteConnection(DBFile))
                {
                    User user = db.Query<User>("SELECT * FROM User WHERE Login = ?", login).First();
                    return db.GetWithChildren<User>(user.ID);
                }
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex);
                return null;
            }
        }

        static public Specialty GetSpecialty(string specName)
        {
            try
            {
                using(SQLiteConnection db = new SQLiteConnection(DBFile))
                {
                    Specialty spec = db.Query<Specialty>("SELECT * FROM Specialty WHERE Name = ?", specName).First();
                    return db.GetWithChildren<Specialty>(spec.ID);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
                return null;
            }
        }

        static public Patient GetPatient(string login)
        {
            try
            {
                using(SQLiteConnection db = new SQLiteConnection(DBFile))
                {
                    User user = db.Query<User>("SELECT * FROM User WHERE Login = ?", login).First();
                    Patient patient = db.Query<Patient>("SELECT * FROM Patient WHERE UserID = ?", user.ID).First();
                    return db.GetWithChildren<Patient>(patient.PatientID);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
                return null;
            }
        }

        static public PatientCard GetPatientCard(string cardNumber)
        {
            try
            {
                using(SQLiteConnection db = new SQLiteConnection(DBFile))
                {
                    PatientCard card = db.Query<PatientCard>("SELECT * FROM PatientCard WHERE CardNumber = ?", cardNumber).First();
                    return db.GetWithChildren<PatientCard>(card.CardID);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
                return null;
            }
        }

        static public Doctor GetDoctor(string login)
        {
            try
            {
                using(SQLiteConnection db = new SQLiteConnection(DBFile))
                {
                    User user = db.Query<User>("SELECT * FROM User WHERE Login = ?", login).First();
                    Doctor doctor = db.Query<Doctor>("SELECT * FROM Doctor WHERE UserID = ?", user.ID).First();
                    return db.GetWithChildren<Doctor>(doctor.DoctorID);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ShowError(ex);
                return null;
            }
        }
    }
}