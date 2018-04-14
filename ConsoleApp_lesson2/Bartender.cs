using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Bartender : Human
    {
        public List<Place> Places; // столики
        public List<Order> Orders;
        public int Tip { get; set; } // чайові

    }
}
