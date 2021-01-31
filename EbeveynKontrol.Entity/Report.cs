using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynKontrol.Entity
{
    public class Report
    {
        public int Id { get; set; }
        public string SiteTitle { get; set; }
        public DateTime DateTime { get; set; }
        public int BanID { get; set; }


        public Ban Ban { get; set; }
    }
}
