using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lesson2
{
    class Menu
    {

        public List<Dish> Dishes;
        public List<Drink> Drinks;

        public Menu()
        {

            CreateDish();
            CreateDrink();

        }

        public void CreateDish()
        {

            for (int i=0; i<(MyRand.RandNum(10, 45)); i++)
            {
                Dish d = new Dish();
                this.Dishes.Add(d);

            }

        }

        public void CreateDrink()
        {

            for (int i = 0; i < (MyRand.RandNum(10, 45)); i++)
            {
                Drink d = new Drink();
                this.Drinks.Add(d);
            }

        }

    }
}
