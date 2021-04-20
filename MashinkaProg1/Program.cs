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
            string PROFF = @"C:\Coding\VScodes\Mashinki\MashinkaProg1\Data\Professions.txt";
            string SALARY = @"C:\Coding\VScodes\Mashinki\MashinkaProg1\Data\Salary.txt";
            List<Employee> Employees = new List<Employee>();
            string[] names = File.ReadAllLines(NAMES);
            string[] groups = File.ReadAllLines(GROUP);
            string[] professions = File.ReadAllLines(PROFF);
            string[] salarys = File.ReadAllLines(SALARY);
            int prof;
            Random rand1 = new Random();
            for(int i = 0; i < 180; i++)
            {
                bool sex;
                int sost = rand1.Next(0,100);
                if (sost <= 75) sost = 0;
                else if (sost > 75 && sost <= 87) sost = 1;
                else if (sost > 87 && sost <= 94) sost = 2;
                else sost = 3;
                if (rand1.Next(0, 10) == 0) sex = false;
                else sex = true;
                prof = rand1.Next(0, 57);
                Employee pers = new Employee(names[rand1.Next(0, 59)], rand1.Next(14, 65), sost, sex, professions[prof], int.Parse(salarys[prof]), 0, 0);
                Employees.Add(pers);
                WriteLine(Employees[i].WorkGetInfo());
                WriteLine();
                for (int j = 0; j < rand1.Next(10, 30); j++)
                {
                    Employees[i].Work();
                }
                WriteLine();
                WriteLine(Employees[i].WorkGetInfo());
                WriteLine();
                WriteLine();
                WriteLine();
            }
            ReadLine();
        }
    }
}
