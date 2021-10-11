using System;
using System.Data;
using System.Collections.Generic;

namespace _07_09_21
{
    public class DAL_SV 
    {
        private static DAL_SV _Instance;
        public static DAL_SV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_SV();
                }
                return _Instance;
            }
            private set {}
        }

        public SV GetSV(DataRow dr) 
        {
            return new SV
            {
                MSSV = dr["MSSV"].ToString(),
                Name = dr["Name"].ToString(),
                Age = Convert.ToInt32(dr["Age"]),
            };
        }
        public List<SV> getAllSV()
        {
            List<SV> list = new List<SV>();
            String query = "SELECT * FROM sinh_vien";
            DataTable dt = DataProvider.Instance.GetRecords(query);

            foreach (DataRow row in dt.Rows)
            {
               list.Add(GetSV(row));                 
            }            
            return list;            
        }

        // public void AddSV(SV s)
        // {
        //     string query = "..";
        //     DataProvider.Instance.ExecuteQuery(query)
        // }        
    }
        
}
