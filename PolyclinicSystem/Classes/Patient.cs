using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

public class Patient
{
    [PrimaryKey, AutoIncrement]
    public int PatientID { get; set; }

    [NotNull, MaxLength(1)]
    public string Gender { get; set; }

    [NotNull, MaxLength(16)]
    public string OMS { get; set; }

    public string JobPlace { get; set; }

    [NotNull]
    public string Address { get; set; }

    [NotNull]
    public string BirthDate { get; set; }

    [NotNull, MaxLength(11)]
    public string Phone { get; set; }

    [ForeignKey(typeof(User))]
    public int UserID { get; set; }

    [ManyToOne]
    public User User { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<PatientCard> PatientCards { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Feedback> Feedbacks { get; set; }

    public void Edit(string oms, string jobplace, string address, string phone)
    {
        OMS = oms;
        JobPlace = jobplace;
        Address = address;
        Phone = phone;
    }
}

