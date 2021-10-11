using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace _07_09_21
{
    class Program
    {
        static void Main(string[] args)
        {
       
             foreach (SV i in BUS_SV.Instance.getListSV())
            {
                Console.WriteLine(i);               
            }   
            // Console.WriteLine(BUS_SV.Instance.getListSV().Count);
        }
    }
}
