using System;
using System.Text;

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


            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Have you ever had a DUI?");
            //bool DUI = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("How many speeding tickets do you have?");
            //int tickets = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Qualified?");
            //bool qualified = age > 15 && DUI == false && tickets <= 3;
            //Console.WriteLine(qualified);
            //Console.Read();

            //string result = 2 > 1 ? "test1" : "test2";
            //Console.WriteLine(result);


            //Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Console.WriteLine("Please enter the package weight:");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter the package width:");
            //double width = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter the package height:");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter the package length:");
            //double length = Convert.ToDouble(Console.ReadLine());
            //double size = width + height + length;
            //if (size > 50)
            //{
            //    Console.WriteLine("Package too big to be shipped via Package Express.");
            //}
            //else
            //{
            //    double total = (height * width * length * weight) / 100;
            //    Console.WriteLine("Your estimated total for shipping this package is: $" + total.ToString("F"));
            //    Console.WriteLine("Thank you!");
            //}
            //Console.Read();

            //int i = 0;
            //bool go = true;
            //while (go)
            //{
            //    i++;
            //    if (i < 10)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else if (i == 10)
            //    {
            //        go = false;
            //    }
            //}
            //Console.WriteLine("--");
            //i = 0;
            //go = true;
            //do
            //{
            //    i++;
            //    if (i < 10)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else if (i == 10)
            //    {
            //        go = false;
            //    }
            //}
            //while (go);
            //Console.Read();


            Console.WriteLine("string 1 " + "string 2 " + "string 3");
            string line = "this is a string";
            Console.WriteLine(line.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("Lorem ipsum dolor sit amet, libris populo sea ne, sit illum discere cu, cum no menandri sapientem. ");
            sb.Append("Ex veritus tibique has, te eum adhuc vulputate. ");
            sb.Append("Eam an facer persius appareat, id idque dolor fastidii nec. ");
            sb.Append("Suas consul tamquam usu in, quo id offendit suscipiantur. ");
            sb.Append("Magna constituto an his, mel sint omnium te. ");
            sb.Append("Qui quod paulo in, mel ex elit everti definitionem, et quis adhuc numquam vis.");
            Console.WriteLine(sb);
            Console.Read();
        }
    }
}