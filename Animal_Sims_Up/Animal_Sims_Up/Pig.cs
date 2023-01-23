using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Animal_Sims_Up
{
    internal class Pig : Animal
    {
        public Pig(string _name, int _age, int _slot)
        {
            Name = _name;
            Age = _age;
            Slot = _slot;
            FoodName = "Wheat";
        }
        public static int MaxAge = 20;

        public override void Drink()
        {
            if (Global.FoodAmount["Water"] <= 0)
                return;
            Global.FoodAmount["Water"]--;

            drink += 10;
            drink = Math.Clamp(drink, 0, 100);
        }

        public override void Eat()
        {
            if (Global.FoodAmount[$"{FoodName}"] <= 0)
                return;
            Global.FoodAmount[$"{FoodName}"]--;

            food += 30;
            food = Math.Clamp(food, 0, 100);
        }

        public override void Sleep()
        {
            sleep += 10;
            sleep = Math.Clamp(sleep, 0, 100);
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
