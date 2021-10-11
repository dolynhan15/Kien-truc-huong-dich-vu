using System;
using System.Collections.Generic;

#nullable disable

namespace _14_09_21.Models
{
    public partial class SinhVien
    {
        public int Mssv { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int Idlop { get; set; }
        public override string ToString()
        {
            return "MSSV: " + Mssv + " Name: " + Name + " Age: " + Age;
        }
        public virtual Lopsh IdlopNavigation { get; set; }
    }
}
