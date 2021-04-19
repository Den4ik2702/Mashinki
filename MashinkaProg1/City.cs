using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashinka
{
    class City
    {
        protected string name { get; set; }
        protected int numPers { get; set; }
        public City(string name, int numPers)
        {
            this.name = name;
            this.numPers = numPers;
        }
    }
}
