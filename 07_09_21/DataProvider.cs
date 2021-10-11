using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace _07_09_21
{
    public class DataProvider 
    {
        private MySqlConnection cnn;
        private static DataProvider _Instance;
        public static DataProvider Instance
        {
            get
            {
                if (_Instance == null)
                {
                    String str_cnn = @"server=127.0.0.1;user=root;password=12345;database=example07_09_21";
                    // String str_cnn = "";
                    _Instance = new DataProvider(str_cnn);
                }
                return _Instance;
            }
            private set {}
        }
        private DataProvider(string str_cnn)
        {
            cnn = new MySqlConnection(str_cnn);

        }
        public DataTable GetRecords(string query)
        {            
            DataTable data = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);      
            cnn.Open();      
            da.Fill(data);
            cnn.Close();
            return data;
        }
    }
}
