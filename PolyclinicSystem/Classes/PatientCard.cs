using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

public class PatientCard
{
    [PrimaryKey, AutoIncrement]
    public int CardID { get; set; }

    [ForeignKey(typeof(Patient))]
    public int PatientID { get; set; }

    [ManyToOne]
    public Patient Patient { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<DoctorVisit> DoctorVisits { get; set; }
}
