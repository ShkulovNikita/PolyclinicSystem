using SQLite;
using SQLiteNetExtensions.Attributes;

public class Administrator
{
    [PrimaryKey, AutoIncrement]
    public int AdminID { get; set; }

    [NotNull, MaxLength(11)]
    public string Phone { get; set; }

    [ForeignKey(typeof(User))]
    public int UserId { get; set; }

    [ManyToOne]
    public User User { get; set; }
}

