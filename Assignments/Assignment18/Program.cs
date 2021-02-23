using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be saved to a file: ");
            int input = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = File.CreateText(@"C:\Users\Michael\Documents\GitHub\Basic-C-Sharp-Projects\Assignments\Assignment18\number.txt"))
            {
                file.WriteLine(input);
            }
            string output;
            using (StreamReader file = File.OpenText(@"C:\Users\Michael\Documents\GitHub\Basic-C-Sharp-Projects\Assignments\Assignment18\number.txt"))
            {
                output = file.ReadLine();
            }
            Console.WriteLine("The number that was saved to the file was: " + output);

            Console.Read();
        }
    }
}
