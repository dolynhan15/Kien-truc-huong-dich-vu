using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace _11_10_21_Code
{
    [Table("SinhVien")] //get name here not table's name in mySql
    public class SV
    {
        [Key][Required][StringLen(50)]
        public string MSSV { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        
        [ForeignKey("IDlop")]
        public int IDlop { get; set; }
        
    }
}