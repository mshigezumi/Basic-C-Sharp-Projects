using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number(10.0m);
            Console.WriteLine(num.Amount);
            Console.Read();
        }

        public struct Number
        {
            public decimal Amount;

            public Number(decimal amount)
            {
                Amount = amount;
            }
        }
    }
}