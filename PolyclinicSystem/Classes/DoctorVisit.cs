using SQLite;
using SQLiteNetExtensions.Attributes;

public class DoctorVisit
{
    [PrimaryKey, AutoIncrement]
    public int VisitID { get; set; }

    public string Type { get; set; }

    [NotNull]
    public string Date { get; set; }

    public string Complaints { get; set; }

    public string Diagnosis { get; set; }

    public string Treatment { get; set; }

    [NotNull]
    public string Status { get; set; }

    [ForeignKey(typeof(Doctor))]
    public int DoctorID { get; set; }

    [ForeignKey(typeof(PatientCard))]
    public int PatientCardID { get; set; }

    [ManyToOne]
    public Doctor Doctor { get; set; }

    [ManyToOne]
    public PatientCard PatientCard { get; set; }
}