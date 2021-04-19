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
            
        }

    }
}
