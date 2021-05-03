using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

public class Specialty
{
    [PrimaryKey, AutoIncrement]
    public int ID { get; set; }

    [NotNull]
    public string Name { get; set; }

    [OneToMany(CascadeOperations = CascadeOperation.All)]
    public List<Doctor> Doctors { get; set; }
}
