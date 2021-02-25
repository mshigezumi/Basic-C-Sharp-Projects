using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    class Program
    {
        static void Main(string[] args)
        {
            const string test = "this is a test";
            var test2 = 2;
        }

        public string name;
        public int number;

        public Program(string name)
        {
            this.name = name;
        }

        public Program(string name, int number) : this(name)
        {
            this.name = name;
            this.number = number;
        }
        //assignment on page 310
    }
}
