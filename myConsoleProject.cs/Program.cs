using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();

            Console.WriteLine("What is your favorite number?");
            string numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);
            int result = number + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + result);
            Console.Read();
        }
    }
}