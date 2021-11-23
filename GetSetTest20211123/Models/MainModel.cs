using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTest20211123.Models
{
    public class Calc
    {
        public int count { get; set; }
        public int money { get; set; }
        public int total { get { return count * money; } }
    }
}
