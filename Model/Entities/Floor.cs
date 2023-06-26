using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Floor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
