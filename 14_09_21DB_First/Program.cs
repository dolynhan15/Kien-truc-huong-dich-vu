using System;
using System.Linq;
using _14_09_21.Models;

namespace _14_09_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq to Entities

            //---SELECT---
            example07_09_21Context db = new example07_09_21Context();
            // var s = (from p in db.SinhViens select new {p.Mssv, p.Name, p.IdlopNavigation.Namelop});

            // var s = db.SinhViens.Select(p => new {p.Mssv, p.Name, p.IdlopNavigation.Namelop}).ToList();

            // var s = (from p in db.SinhViens
            //         where p.Name == "nhan"
            //         select new {p.Mssv, p.Name, p.IdlopNavigation.Namelop})
            //         .ToList();

            // var s = db.SinhViens.Where(p => p.Name == "nhan");

            // var s = db.SinhViens.Where(p => p.Name == "nhan")
            //         .Select(p => new  {p.Mssv, p.Name, p.IdlopNavigation.Namelop});
            // foreach (var i in s)
            // {
            //     Console.WriteLine(i);
            // }

            //---ADD---
            // SinhVien sv1 = new SinhVien()
            // {
            //     Mssv = 102180192, 
            //     Name = "Phan The Tue",
            //     Age = 21,
            //     Idlop = 1,
            // };
            // db.SinhViens.Add(sv1);
            // db.SaveChanges();

            //---DELETE---
            // db.SinhViens.Remove(sv1);
            // db.SaveChanges();

            //---DELETE---
            // int E_MSSV = 102180192;
            // SinhVien e = db.SinhViens.Find(E_MSSV);
            // e.Name = "The Tue";
            // db.SaveChanges();
            // // foreach (SinhVien i in db.SinhViens)
            // // {
            // //     Console.WriteLine(i.ToString());
            // // }
            // foreach (var i in db.SinhViens.ToList())
            // {
            //     Console.WriteLine(i.ToString());
            // }

            foreach (var i in db.SinhViens) 
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
