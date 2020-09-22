using System;
using System.Collections.Generic;
using System.Text;

namespace ContohXamarinSep2020
{
    public class Global
    {
        public Global()
        {

        }
        private static Global _instance;
        public static Global Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new Global();
                }
                return _instance; 
            }
        }

        //properti yang dibuat global
        public string myData { get; set; }
    }
}
