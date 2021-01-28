using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number");
            string input = Console.ReadLine();
            int number2 = 0;
            if (input != "")
            {
                number2 = Convert.ToInt32(input);
            }
            MathOperations math = new MathOperations();
            math.Add(number, number2);
            Console.WriteLine("--");
            Console.WriteLine(math.result1);
            Console.WriteLine(math.result2);
            Console.Read();
        }
    }
}
