using System;
using System.Collections.Generic;

namespace _07_09_21
{
    public class BUS_SV 
    {
        private static BUS_SV _Instance;
        public static BUS_SV Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_SV();
                }
                return _Instance;
            }
            private set {}
        }
        
        // private BUS_SV()
        // {
        //     _Instance = new BUS_SV();
        //     return _Instance;
        // }

        public List<SV> getListSV()
        {
            return DAL_SV.Instance.getAllSV();
        }
    }
        
}
