using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Restaurant
    {

        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Human> Owners;
        public Kitchen Kitchen { get; set; }
        public List<Hall> Halls;
        public Bar Bar { get; set; }

        
        public Restaurant()
        {

        }

    }
}
