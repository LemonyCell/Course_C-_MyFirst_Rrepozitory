using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Bar : Room
    {

        public List<Bartender> Bartenders;
        //public List<> 
        public List<Place> Places;
        public List<Client> Clients;

        public Bar()
        {
            for (int i = 0; i < MyRand.RandNum(1, 12); i++)
            {
                Place p = new Place();
                this.Places.Add(p);
            }
        }

    }
}
