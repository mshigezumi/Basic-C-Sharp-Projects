using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quit = new Employee();
            quit.Quit();
            Console.Read();
        }
    }
}
