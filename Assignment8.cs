using System;

class Assignment
{
    static void Main()
    {
        Console.WriteLine("Input a number");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input a second number (optional)");
        string input = Console.ReadLine();
        int number2 = 0;
        if (input != "")
        {
            number2 = Convert.ToInt32(input);
        }
        MathOperations math = new MathOperations();
        Console.WriteLine(math.Add(number, number2));
        Console.Read();
    }
}