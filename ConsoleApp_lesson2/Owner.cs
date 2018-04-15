using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Owner : Human
    {

        public List<Restaurant> Restaurants;


        public Owner( ref Restaurant r)
        {
            Restaurants.Add(r);
        }
        public Owner()
        {
            
        }
    }
}
