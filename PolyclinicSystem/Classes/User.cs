using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

public class User
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }

    [Unique]
    public string Login { get; set; }

    [NotNull]
    public string Name { get; set; }

    [NotNull]
    public string Email { get; set; }

    [NotNull]
    public string Password { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Administrator> Administrators { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Patient> Patients { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Doctor> Doctors { get; set; }

    public void Edit(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void ChangePassword(string newPassword)
    {
        Password = newPassword;
    }
}