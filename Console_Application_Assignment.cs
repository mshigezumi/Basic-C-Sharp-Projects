using System;

class Assignment2
{
    static void Main()
    {
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