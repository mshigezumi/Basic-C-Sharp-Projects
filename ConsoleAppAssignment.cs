using System;

class Assignment
{
    static void Main()
    {
        int i = 0;
        bool go = true;
        while (go)
        {
            i++;
            if (i < 10)
            {
                Console.WriteLine(i);
            }
            else if (i == 10)
            {
                go = false;
            }
        }
        Console.WriteLine("--");
        i = 0;
        go = true;
        do
        {
            i++;
            if (i < 10)
            {
                Console.WriteLine(i);
            }
            else if (i == 10)
            {
                go = false;
            }
        }
        while (go);
        Console.Read();
    }
}