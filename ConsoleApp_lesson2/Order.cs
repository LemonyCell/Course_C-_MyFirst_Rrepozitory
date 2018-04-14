using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Order
    {

        public List<string> Meals;
        public OrderStatus OrderStatus; // статус замовлення
        public string PlaceWhereOrdered { get; set; }

    }
}
