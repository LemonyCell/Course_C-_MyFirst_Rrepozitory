using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Hall : Room
    {
        //public string Id { get; set; }

        public List<Waiter> Waiters;
        public List<Place> Places;
        public List<Client> Clients;

        //public List<Human> Administrators;
        //public int Number;

        public Hall()
        {
            for (int i=0; i< MyRand.RandNum(1,20); i++)
            {
                Place p = new Place();
                this.Places.Add(p);
            }
        }
        
    }
}
