﻿using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace PolyclinicSystem.Classes
{
    public class PatientCard
    {
        [PrimaryKey, AutoIncrement]
        public int CardID { get; set; }

        [Unique, NotNull]
        public string CardNumber { get; set; }

        [ForeignKey(typeof(Patient))]
        public int PatientID { get; set; }

        [ManyToOne]
        public Patient Patient { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<DoctorVisit> DoctorVisits { get; set; }
    }
}