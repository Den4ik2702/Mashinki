using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinka
{
    class Person
    {
        protected string name;
        protected int age;
        protected int alive;
        protected bool sex;
        public Person(string name, int age, int alive, bool sex)
        {
            this.name = name;
            this.age = age;
            this.alive = alive;
            this.sex = sex;
        }

        public void GetInfo()
        {
            switch(alive)
            {
                case 0:
                    Console.WriteLine("Состояние - Живой");
                    break;

                case 1:
                    Console.WriteLine("Состояние - Долбоеб");
                    break;

                case 2:
                    Console.WriteLine("Состояние - Dd inside");
                    break;

                case 3:
                    Console.WriteLine("Состояние - Мёртвый");
                    break;
            }

            Console.WriteLine($"Имя - {name}");
            Console.WriteLine($"Возраст - {age}");

            if(sex)
                Console.WriteLine($"Пол - Мужской");
            else
                Console.WriteLine($"Пол - Женский");
        }
    }
}
