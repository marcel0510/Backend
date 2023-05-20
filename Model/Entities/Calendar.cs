using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Calendar: BaseEntity
    {
        public string Period { get; set; }
        public DateTime PeridoInit { get; set; }
        public DateTime PeriodEnd { get; set;}
        List<Classroom> Classrooms { get; set; }
    }
}
