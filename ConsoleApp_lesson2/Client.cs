using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Client : Human
    {

        public Place Place { get; set; }
        public List<string> Order;
        public ClientStatus ClientStatus; // статус клієнта

    }
}
