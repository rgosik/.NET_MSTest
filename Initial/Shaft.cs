using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    public class Shaft
    {
        public int income;
        public string name;
        public Shaft(int x)
        {
            income = x;
        }
        public Shaft(string name)
        {
            this.name = name;
        }
        public Shaft()
        {
            income = 0;
        }
    }
}
