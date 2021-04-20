using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinka
{
    class Tank: Transport
    {
        private bool readyToShoot = false;

        public Tank(string mark, int speed, string color, string fuel, int time)
            : base(mark, speed, color, fuel, time)
        {

        }

        public void Shoot(List<Person> person)
        {
            if (readyToShoot)
            {
                var rnd = new Random();
                int numDead = rnd.Next(0, 6);
                readyToShoot = false;

                Console.WriteLine("ВЫСТРЕЛ!");
                Console.WriteLine($"Убито {numDead} человек!");

                if (numDead > 0)
                {
                    Console.WriteLine("Выстрел успешен!");
                    Dead(numDead, person);
                }
                else
                    Console.WriteLine("Убытых нет - повторите залп!");
            }
            else
            {
                Console.WriteLine("Пушка не готова!" +
                    "\nТребуется перезарядка!");
                ReloadGun();
                Shoot(person);
            }
        }

        private void ReloadGun()
        {
            Console.WriteLine("Пушка перязаряжается!");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(".");
                Task.Delay(100).GetAwaiter().GetResult();
            }
            readyToShoot = true;
        }

        private void Dead(int numDead, List<Person> people)
        {
            var rnd = new Random();
            for (int i = 0; i < numDead; i++)
            {
                int num = (int)rnd.Next(people.Count);
                if (people[num].ShotInfo().Contains("Мёртвый"))
                {
                    if (numDead <= people.Count)
                    {
                        numDead++;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Все мертвы - стрелять не в кого!\n" +
                            "ВЫ ДОБЛЕСТНЫЙ БОЕЦ!");
                        return;
                    }
                        
                }
                people[num].ChangeAlive(3);
                Console.WriteLine(people[num].ShotInfo());
                Console.WriteLine();
            }
        }
    }
}
