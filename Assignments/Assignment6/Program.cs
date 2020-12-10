using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            MathOperations math = new MathOperations();
            Console.WriteLine(math.Add(number));
            Console.WriteLine(math.Subtract(number));
            Console.WriteLine(math.Multiply(number));
            Console.Read();
        }
    }
}
