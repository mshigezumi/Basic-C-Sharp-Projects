using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment2
{
    class Program
    {
        static void Main()
        {
            string[] PhoneticAlphabet = { "Alfa", "Bravo", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel", "India", "Juliett" };
            Console.WriteLine("Input text to be added to each string");
            string add = Console.ReadLine();
            int i = 0;
            foreach (string letter in PhoneticAlphabet)
            {
                PhoneticAlphabet[i] = letter + add;
                i++;
            }
            foreach (string letter in PhoneticAlphabet)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine("--");

            bool go = true;
            //while (go)
            //{
            //    Console.WriteLine("This will never end.");
            //}

            i = 0;
            do
            {
                Console.WriteLine("This will end.");
                i++;
                if (i > 9) { go = false; }
            } while (go);

            Console.WriteLine("--");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--");

            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--");

            List<string> listPA = new List<string>();
            listPA.Add("Alfa");
            listPA.Add("Bravo");
            listPA.Add("Charlie");
            listPA.Add("Delta");
            listPA.Add("Echo");
            listPA.Add("Foxtrot");
            listPA.Add("Golf");
            listPA.Add("Hotel");
            listPA.Add("India");
            listPA.Add("Juliett");
            Console.WriteLine("Input text to be searched for in the list");
            string search = Console.ReadLine();

            go = true;
            i = 0;
            bool found = false;
            do
            {
                if (listPA[i].Contains(search))
                {
                    Console.WriteLine("Index " + i + " contains input text");
                    found = true;
                    go = false;
                }
                i++;
                if (found == false && i == listPA.Count)
                {
                    Console.WriteLine("Input is not on the list");
                    go = false;
                }
            } while (go);

            Console.WriteLine("--");

            listPA.Add("Alfa");
            Console.WriteLine("Input text to be searched for in the list");
            search = Console.ReadLine();

            go = true;
            i = 0;
            found = false;
            do
            {
                if (listPA[i].Contains(search))
                {
                    Console.WriteLine("Index " + i + " contains input text");
                    found = true;
                }
                i++;
                if (i == listPA.Count)
                {
                    if (found == false)
                    {
                        Console.WriteLine("Input is not on the list");
                    }
                    go = false;
                }
            } while (go);

            Console.WriteLine("--");

            listPA.Add("Bravo");
            listPA.Add("Charlie");
            listPA.Add("Zulu");
            List<string> appeared = new List<string>();
            foreach (string item in listPA)
            {
                if (appeared.Contains(item))
                {
                    Console.WriteLine(item + " has already appeared in the list");
                }
                else
                {
                    Console.WriteLine(item + " has not already appeared in the list");
                    appeared.Add(item);
                }
            }

            Console.Read();
        }
    }
}
