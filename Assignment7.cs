using System;

class Assignment
{
    static void Main()
    {
        int number = 5;
        decimal number2 = (decimal)5.5;
        string number3 = "5";
        MathOperations math = new MathOperations();
        Console.WriteLine(math.Add(number));
        Console.WriteLine(math.Add(number2));
        Console.WriteLine(math.Add(number3));
        Console.Read();
    }
}