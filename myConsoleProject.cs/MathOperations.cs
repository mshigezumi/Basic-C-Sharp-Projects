﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConsoleProject.cs
{
    public class MathOperations
    {
        public int Add(int x)
        {
            return 10 + x;
        }

        public int Subtract(int x)
        {
            return 10 - x;
        }

        public int Multiply(int x)
        {
            return 10 * x;
        }

        public int Add(decimal x)
        {
            return Convert.ToInt32(20 + x);
        }

        public int Add(string x)
        {
            return 30 + Convert.ToInt32(x);
        }

        public int Add(int x, int y = 0)
        {
            return x + y;
        }

        public void Show(int x, int y)
        {
            x = x + 10;
            Console.WriteLine(y);//I don't know if this is what it's asking for
        }
    }
}