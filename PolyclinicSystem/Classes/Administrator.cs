﻿using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PolyclinicSystem.Classes
{
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

        public void Edit(string phone)
        {
            Phone = phone;
        }
    }
}