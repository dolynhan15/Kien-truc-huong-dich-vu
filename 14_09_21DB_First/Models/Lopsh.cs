using System;
using System.Collections.Generic;

#nullable disable

namespace _14_09_21.Models
{
    public partial class Lopsh
    {
        public Lopsh()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public int Idlop { get; set; }
        public string Namelop { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
