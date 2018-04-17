using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp_lesson2
{
    class Data
    {
        // тут var не канає хз чого
        public static List<Restaurant> Restaurants = new List<Restaurant>();

        public void Start()
        {
            //var r = new Restaurant();
            //r = CreateRestaurant();
            //Restaurants.Add(r);

            Restaurants.Add(CreateRestaurant());
        }

        public Restaurant CreateRestaurant()
        {
            var r = new Restaurant();

            r.Name = NameOfRestaurant();
            r.Adress = AdressOfRestaurant();

            r.Owners = new List<Owner>();

            for (int i = 0; i < MyRand.RandNum(1, 5); i++)
            {
                var o = new Owner();
                o = CreateOwner();

                r.Owners.Add(o);
            }


            return r;
        }

        public string NameOfRestaurant()
        {
            string name = MyRand.RandSrtUpper(MyRand.RandNum(4, 15));

            return name;
        }

        public string AdressOfRestaurant()
        {
            string adress = MyRand.RandSrtUpper(MyRand.RandNum(10, 25));

            return adress;
        }

        // тут канає тільки void, тому юзаю ref
        public void CreateHuman<H> (ref H h) where H : Human
        {
            h.FirstName = MyRand.RandSrtUpper(MyRand.RandNum(4, 12));
            h.LastName = MyRand.RandSrtUpper(MyRand.RandNum(4, 12));
            h.Age = MyRand.RandNum(18, 65);
            h.Sex = (Gender)MyRand.RandNum(0, 2); // якщо 1, а не 2, то будуть тільки 0

            // потім напишу
            //h.Id = Convert.ToString(God.NumOfHuman);
        }

        public Owner CreateOwner()
        {
            var o = new Owner();
            CreateHuman<Owner>(ref o);

            // коли добавлю в клас Owner ше поля, то допишу тут код

            return o;
        }

    }
}
