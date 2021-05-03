using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

public class Doctor
{
    [PrimaryKey, AutoIncrement]
    public int DoctorID { get; set; }

    [ForeignKey(typeof(Specialty))]
    public int SpecialtyID { get; set; }

    [ForeignKey(typeof(User))]
    public int UserID { get; set; }

    [ManyToOne]
    public User User { get; set; }

    [ManyToOne]
    public Specialty Specialty { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<DoctorVisit> DoctorVisits { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Feedback> Feedbacks { get; set; }
}
