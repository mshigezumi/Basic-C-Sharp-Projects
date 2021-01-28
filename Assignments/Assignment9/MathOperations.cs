using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class MathOperations
    {
        public static int result1;
        public static int result2;
        public void Add(int x, int y)
        {
            x += 10;
            Console.WriteLine(y);
            result1 = x;
            result2 = y;
        }
    }
}
