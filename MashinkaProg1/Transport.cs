using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinka
{
    class Transport
    {
        protected string mark;
        protected int speed;
        protected string color;
        protected string fuel;
        protected int time;

        public Transport(string mark, int speed, string color, string fuel, int time)
        {
            this.mark = mark;
            this.speed = speed;
            this.color = color;
            this.fuel = fuel;
            this.time = time;
        }

        public void Print()
        {
            Console.WriteLine($"Марка: {mark}");
            Console.WriteLine($"Максимальная скорость: {speed}");
            Console.WriteLine($"Цвет: {color}");
            Console.WriteLine($"Тип топлива: {fuel}");
            Console.WriteLine($"Год выпуска: {time}");
        }
    }
}
