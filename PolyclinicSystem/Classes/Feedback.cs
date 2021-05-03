using SQLite;
using SQLiteNetExtensions.Attributes;

public class Feedback
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }

    [NotNull]
    public int Rating { get; set; }

    [NotNull]
    public string Date { get; set; }

    [NotNull]
    public string Text { get; set; }

    [ForeignKey(typeof(Patient))]
    public int PatientID { get; set; }

    [ForeignKey(typeof(Doctor))]
    public int DoctorID { get; set; }

    [ManyToOne]
    public Patient Patient { get; set; }

    [ManyToOne]
    public Doctor Doctor { get; set; }
}
