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

        public string GetInfo()
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

            if(sex)
                info += ($"Пол: Мужской\n");
            else
                info += ($"Пол: Женский\n");

            return info;
        }
        public string ShotInfo()
        {
            string info = "";   
            switch (alive)
            {
                case 0:
                    info += "Состояние: Живой\t| ";
                    break;

                case 1:
                    info += "Состояние: Долбоеб\t| ";
                    break;

                case 2:
                    info += "Состояние: Ded inside\t| ";
                    break;

                case 3:
                    info += "Состояние: Мёртвый\t| ";
                    break;
            }
            info +=  $"Имя: {name}\t\t| ";
            info +=  $"Возраст: {age}\t| ";

            if (sex)
                info +=  $"Пол: Мужской\t| ";
            else
                info += $"Пол: Женский\t| ";
            return info;
        }

        public void ChangeAlive(int newStatus)
        {
            alive = newStatus;
        }
    }
}
