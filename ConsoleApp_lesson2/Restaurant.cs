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

        public List<Owner> Owners;

        public Kitchen Kitchen { get; set; }
        public List<Hall> Halls;
        public Bar Bar { get; set; }
        public Toilet Toilet { get; set; }

        public Menu Menu { get; set; }

        public List<Administrator> Administrators;
        public List<Cleaner> Cleaners;

        
        public Restaurant()
        {
            //God g = new God();
            this.Name = MyRand.RandSrtUpper(MyRand.RandNum(4, 15));
            this.Adress = MyRand.RandSrtUpper(MyRand.RandNum(10, 25));
        }

    }
}
