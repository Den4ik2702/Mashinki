using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinka
{
    class Student : Person
    {
        protected string profession;
        protected int course;
        protected string group;
        public int studTime;
        public Student(string name, int age, int alive, bool sex, string _profession, int _course, string _group, int _studTime)
            : base(name, age, alive, sex)
        {
            profession = _profession;
            course = _course;
            group = _group;
            studTime = _studTime;
        }

        public void Learn()
        {
            if (alive == 3) { return; }
            else
            {
                Console.WriteLine($"Студент {name} учится. {studTime}/100 студ часов");
                studTime += 1;
                if (studTime % 25 == 0) 
                {
                    course++;
                    Console.WriteLine($"Студент {name} перешел на {course} курс");
                }
            }
        }

        public string StudGetInfo()
        {
            string info = "";
            switch (alive)
            {
                case 0:
                    info += ("Состояние: Живой\n");
                    break;
                case 1:
                    info += ("Состояние: Долбоеб\n");
                    break;
                case 2:
                    info += ("Состояние: Ded inside\n");
                    break;
                case 3:
                    info += ("Состояние: Мёртвый\n");
                    break;
            }

            info += ($"Имя: {name}\n");
            info += ($"Возраст: {age}\n");

            if (sex)
                info += ($"Пол: Мужской\n");
            else
                info += ($"Пол: Женский\n");

            info += ($"Профессия: {profession}\n");
            info += ($"Курс: {course}\n");
            info += ($"Группа: {group}\n");
            info += ($"Кол-во академ часов: {studTime}/100\n");
            return info;
        }
    }
}
