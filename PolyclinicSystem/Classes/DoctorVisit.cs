using SQLite;
using SQLiteNetExtensions.Attributes;

public class DoctorVisit
{
    [PrimaryKey, AutoIncrement]
    public int VisitID { get; set; }

    public string Type { get; set; }

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

    //перенести дату приема
    public void Move(string newDate)
    {
        Date = newDate;
        Status = "Перенесен";
    }

    //отменить прием
    public void Cancel()
    {
        Status = "Отменен";
        Date = null;
    }

    //завершить прием
    public void Complete()
    {
        Status = "Завершен";
    }

    //записать информацию о приеме
    public void WriteInfo(string type, string complaints, string diagnosis, string treatment)
    {
        Type = type;
        Complaints = complaints;
        Diagnosis = diagnosis;
        Treatment = treatment;
    }
}