using System;

class Assignment
{
    static void Main()
    {
        Console.WriteLine("Input a number");
        int number = Convert.ToInt32(Console.ReadLine());
        MathOperations math = new MathOperations();
        Console.WriteLine(math.Add(number));
        Console.WriteLine(math.Subtract(number));
        Console.WriteLine(math.Multiply(number));
        Console.Read();
    }
}