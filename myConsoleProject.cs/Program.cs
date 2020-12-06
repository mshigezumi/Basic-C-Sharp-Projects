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


            //double input = Convert.ToDouble(Console.ReadLine());
            //double result = input * 50;
            //Console.WriteLine(result);

            //input = Convert.ToDouble(Console.ReadLine());
            //result = input + 25;
            //Console.WriteLine(result);

            //input = Convert.ToDouble(Console.ReadLine());
            //result = input / 12.5;
            //Console.WriteLine(result);

            //input = Convert.ToDouble(Console.ReadLine());
            //bool resultBool = input > 50;
            //Console.WriteLine(resultBool);

            //input = Convert.ToDouble(Console.ReadLine());
            //result = input % 7;
            //Console.WriteLine(result);

            //Console.Read();


            //Console.WriteLine("Anonymous Income Comparison Program");
            //Console.WriteLine("Person 1\nHourly Rate?");
            //double rate1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Hours worked per week?");
            //double hours1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Person 2\nHourly Rate?");
            //double rate2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Hours worked per week?");
            //double hours2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Annual salary of Person 1:");
            //double result1 = rate1 * hours1 * 52;
            //Console.WriteLine(result1);
            //Console.WriteLine("Annual salary of Person 2:");
            //double result2 = rate2 * hours2 * 52;
            //Console.WriteLine(result2);
            //Console.WriteLine("Does Person 1 make more money than Person 2?");
            //bool compare = result1 > result2;
            //Console.WriteLine(compare);
            //Console.Read();


            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool qualified = age > 15 && DUI == false && tickets <= 3;
            Console.WriteLine(qualified);
            Console.Read();
        }
    }
}