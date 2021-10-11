using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace _14_09_21CodeFirst
{
    [Table("SinhVien")] //get name here not table's name in mySql
    public class LopSH
    {
        [Key]
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        
    }
}