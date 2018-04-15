using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Meal
    {

        public string Name { get; set; }

        public Meal()
        {
            this.Name = MyRand.RandSrt(MyRand.RandNum(5,14));
        }

    }
}
