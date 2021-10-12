using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace _14_09_21CodeFirst
{
    [Table("SinhVien")] //get name here not table's name in mySql
    public class SV
    {
        [Key][Required][StringLen(50)]
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public int Age { get; set; }
        public int ID_lop { get; set; }
        
        [ForeignKey("ID_lop")]
        public virtual LopSH LopSH {get; set}
        
    }
}