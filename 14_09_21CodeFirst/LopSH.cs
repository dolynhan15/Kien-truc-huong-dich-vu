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
        //De tao LopSH truoc -> xay ham dung
        public LopSH() 
        {
            SVs = new HashSet<SV>();
        }

        [Key]
        public int ID_lop { get; set; }
        public string NameLop { get; set; }
        public virtual ICollection<SV> SVs
        
    }
}