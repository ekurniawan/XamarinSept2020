using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContohXamarinSep2020
{

    public class MyMasterPageMasterMenuItem
    {
        public MyMasterPageMasterMenuItem()
        {
            TargetType = typeof(MyMasterPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }
        public string ImageIcon { get; set; }
    }
}