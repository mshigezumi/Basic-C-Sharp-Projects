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
            Thing thing1 = new Thing("test1");
            Thing thing2 = new Thing("test2", 1);

            Console.WriteLine(thing1.name);
            Console.WriteLine(thing1.number);
            Console.WriteLine(thing2.name);
            Console.WriteLine(thing2.number);
            Console.Read();
        }
    }
}
