using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinka
{
    class Employee : Person
    {
        protected int salary;
        protected string profession;
        protected int cash;
        public int workTime;
        public Employee(string name, int age, int alive, bool sex, string _profession, int _salary, int _workTime, int _cash) 
            : base(name, age, alive, sex)
        {
            profession = _profession;
            salary = _salary;
            workTime = _workTime;
            cash = _cash;
        }
        public void Work()
        {
            if(alive == 3) { return; }
            workTime += 1;
            //Console.WriteLine($"Работник {name} работает. {salary}P денег заработано");
            cash += salary;
        }
        public string WorkGetInfo()
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
            info += ($"Зарплата: {salary}P\n");
            info += ($"Накопления: {cash}P\n");
            info += ($"Кол-во рабочих часов: {workTime}\n");
            return info;
        }
    }
}
