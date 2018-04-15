using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class God
    {

        public static long NumOfHuman = 0; // Ids

        public static List<Restaurant> Restaurants;
        
        public void CreateRestaurant(ref Restaurant r)
        {

            for (int i = 0; i < (MyRand.RandNum(1, 5)); i++)
            {
                r.Owners.Add(new Owner(ref r));
            }

            r.Kitchen = new Kitchen();
            r.Halls.Add(new Hall());
            r.Bar = new Bar();
            r.Toilet = new Toilet();

            r.Administrators.Add(new Administrator());
            r.Cleaners.Add(new Cleaner());

            r.Menu = new Menu();
            
        }

        public void HiringEmployees(ref Restaurant r)
        {
            for (int i=0; i<(MyRand.RandNum(1,10)); i++)
            {
                r.Kitchen.Cookers.Add(new Cook());
            }

            for (int i = 0; i < (MyRand.RandNum(1, 15)); i++)
            {
                r.Halls[0].Waiters.Add(new Waiter());
            }

            r.Bar.Bartenders.Add(new Bartender());

            for (int i = 0; i < (MyRand.RandNum(1, 3)); i++)
            {
                r.Cleaners.Add(new Cleaner());
            }
            
        }

        public void ArrivalOfClients(ref Restaurant r)
        {
            for (int i = 0; i < (MyRand.RandNum(1, 10)); i++)
            {
                Client c = new Client();
                r.Halls[0].Clients.Add(c);
                r.Bar.Clients.Add(c);

                TakeASeat(c, r);

            }

        }

        public void TakeASeat(Client c, Restaurant r)
        {
            switch (MyRand.RandNum(0, 1))
            {
                case 0:
                    TakeASeatInHall(c,r);
                    break;
                case 1:
                    TakeASeatInBar(c, r);
                    break;
            }
        }

        public void TakeASeatInHall(Client c, Restaurant r)
        {
            int minLen = 0;
            int maxLen = r.Halls[0].Places.Count();

            r.Halls[0].Places[MyRand.RandNum(minLen, maxLen)].WhoIsPlased.Add(c);
        }

        public void TakeASeatInBar(Client c, Restaurant r)
        {
            int minLen = 0;
            int maxLen = r.Bar.Places.Count();

            r.Bar.Places[MyRand.RandNum(minLen, maxLen)].WhoIsPlased.Add(c);
        }

        public void TakeAnOrderInBar(ref Restaurant r)
        {
            int len = r.Bar.Places.Count();
            for (int i =0; i<len; i++)
            {

            }
        }


        public void Start()
        {
            for (int i=0; i<(MyRand.RandNum(3, 15)); i++)
            {

                Restaurant r = new Restaurant();
                Restaurants.Add(r);
                CreateRestaurant(ref r);

                HiringEmployees(ref r);
                ArrivalOfClients(ref r);

                TakeAnOrderInBar(ref r);


            }
        }
        
    }
}
