using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinka
{
    class Tank: Transport
    {
        private bool ready = false;

        public Tank(string mark, int speed, string color, string fuel, int time)
            : base(mark, speed, color, fuel, time)
        {

        }

        public void Shoot()
        {
            Random rand = new Random();
            switch (rand.Next(0,5))
            {
                case 0:
                    Console.WriteLine("Никого не убило... а жаль");
                    break;

                case 1:
                    Console.WriteLine("Никого не убило... а жаль");
                    break;

                case 2:
                    Console.WriteLine("Никого не убило... а жаль");
                    break;

                case 3:
                    Console.WriteLine("Никого не убило... а жаль");
                    break;

                case 4:
                    Console.WriteLine("Никого не убило... а жаль");
                    break;
            }
        }

    }
}
