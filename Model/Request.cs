using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Request
    {
        public bool Ok { get; set; }
        public int ErrorType { get; set; }
        public List<int> Groups { get; set; } = new List<int> { 0 };

    }
}
