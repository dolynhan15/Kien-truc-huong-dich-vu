using System;
using System.Collections.Generic;

namespace _07_09_21
{
    public class SV
    {
        public String MSSV { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return "MSSV = "+ MSSV + "; Name = "+ Name + "; Age = "+ Age;
        }
    }
}
