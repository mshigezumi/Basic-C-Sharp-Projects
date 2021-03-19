using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    class Thing
    {
        public string name;
        public int number;

        public Thing(string name) : this(name, 0)
        {

        }

        public Thing(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
    }
}
