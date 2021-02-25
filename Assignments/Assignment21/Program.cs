using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                DateTime dt = new DateTime();
                dt = DateTime.Now;
                dt = dt.AddYears(-input);
                Console.WriteLine(dt.Year);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please enter a positive, non-zero number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occured.");
            }
            Console.Read();
        }
    }
}
