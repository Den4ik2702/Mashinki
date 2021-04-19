using System;
using System.Collections.Generic;
using static System.Console;
using System.IO;
using System.Threading;

namespace Mashinka
{
    class Program
    {
        static void Main(string[] args)
        {
            string NAMES = @"C:\Coding\VScodes\Mashinki\MashinkaProg1\Data\Persons.txt";
            string GROUP = @"C:\Coding\VScodes\Mashinki\MashinkaProg1\Data\Group.txt";
            List<Student> students = new List<Student>();
            string[] names = File.ReadAllLines(NAMES);
            string[] groups = File.ReadAllLines(GROUP);
            Random rand1 = new Random();
            for(int i = 0; i < 150; i++)
            {
                bool sex;
                int sost = rand1.Next(0,10000);
                if (sost <= 7500) sost = 0;
                else if (sost > 7500 && sost <= 8700) sost = 1;
                else if (sost > 8700 && sost <= 9400) sost = 2;
                else sost = 3;
                if (rand1.Next(0, 10) == 0) sex = false;
                else sex = true;
                Student pers = new Student(names[rand1.Next(0, 59)], rand1.Next(18, 30), sost, sex, "Студент", 1, groups[rand1.Next(0, 5)], 1);
                students.Add(pers);
                WriteLine(students[i].StudGetInfo());
                WriteLine();
                for (int j = 0; j < rand1.Next(100, 634); j++)
                {
                    students[i].Learn();
                }
                WriteLine();
                WriteLine(students[i].StudGetInfo());
                WriteLine();
                WriteLine();
                WriteLine();
            }
            ReadLine();
        }
    }
}
