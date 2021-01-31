using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynKontrol.Entity
{
    public class Ban
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Report> Reports { get; set; }
    }
}
