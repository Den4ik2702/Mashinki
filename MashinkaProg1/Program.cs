using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;

namespace Mashinka
{
    class Program
    {
        static void Main(string[] args)
        {
            string NAMES = @"C:\Coding\VScodes\Mashinki\MashinkaProg1\Data\Persons.txt";
            List<Person> persons = new List<Person>();
            string[] names = File.ReadAllLines(NAMES);
            Array.Sort(names);
            StreamWriter sw = new StreamWriter(NAMES, false);
            for(int i = 0; i < names.Length; i++)
            {
                sw.WriteLine($"{names[i]}");
            }

            ReadLine();
        }
    }
}
