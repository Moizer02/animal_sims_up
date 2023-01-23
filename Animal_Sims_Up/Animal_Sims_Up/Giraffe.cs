using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up
{
    internal class Giraffe : Animal
    {
        public Giraffe(string _name, int _age, int _slot)
        {
            Name = _name;
            Age = _age;
            Slot = _slot;
            FoodName = "Leaf";
        }
        public static int MaxAge = 30;

        public override void Drink()
        {
            if (Global.FoodAmount["Water"] <= 0)
                return;
            Global.FoodAmount["Water"]--;

            drink += 15;
            drink = Math.Clamp(drink, 0, 100);
        }

        public override void Eat()
        {
            if (Global.FoodAmount[$"{FoodName}"] <= 0)
                return;
            Global.FoodAmount[$"{FoodName}"]--;

            food += 10;
            food = Math.Clamp(food, 0, 100);
        }

        public override void Sleep()
        {
            sleep += 5;
            sleep = Math.Clamp(sleep, 0, 100);
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
