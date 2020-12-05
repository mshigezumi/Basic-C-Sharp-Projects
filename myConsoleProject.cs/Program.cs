using System;

namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + "!");
            //Console.Read();

            //Console.WriteLine("What is your favorite number?");
            //string numberString = Console.ReadLine();
            //int number = Convert.ToInt32(numberString);
            //int result = number + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + result);
            //Console.Read();

            //int answer1 = 2 + 2;
            //Console.WriteLine(answer1);
            //int answer2 = 2 - 2;
            //Console.WriteLine(answer2);
            //int answer3 = 2 * 2;
            //Console.WriteLine(answer3);
            //int answer4 = 2 / 2;
            //Console.WriteLine(answer4);
            //Console.WriteLine("hi " + 5);
            //Console.Read();

            double input = Convert.ToDouble(Console.ReadLine());
            double result = input * 50;
            Console.WriteLine(result);

            input = Convert.ToDouble(Console.ReadLine());
            result = input + 25;
            Console.WriteLine(result);

            input = Convert.ToDouble(Console.ReadLine());
            result = input / 12.5;
            Console.WriteLine(result);

            input = Convert.ToDouble(Console.ReadLine());
            bool resultBool = input > 50;
            Console.WriteLine(resultBool);

            input = Convert.ToDouble(Console.ReadLine());
            result = input % 7;
            Console.WriteLine(result);

            Console.Read();
        }
    }
}