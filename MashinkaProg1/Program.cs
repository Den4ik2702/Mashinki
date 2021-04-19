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
            Random rand_name = new Random();
            for (int i = 0; i < names.Length; i++)
                WriteLine($"{names[rand_name.Next(0,names.Length)]}");

            ReadLine();
        }
    }
}
