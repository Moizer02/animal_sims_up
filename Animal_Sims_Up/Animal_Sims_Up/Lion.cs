using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up
{
    internal class Lion : Animal
    {
        public Lion(string _name, int _age, int _slot)
        {
            Name = _name;
            Age = _age;
            Slot = _slot;
            FoodName = "Beef";
        }
        public static int MaxAge = 16;

        public override void Drink()
        {
            if (Global.FoodAmount["Water"] <= 0)
                return;
            Global.FoodAmount["Water"]--;

            drink += 30;
            drink = Math.Clamp(drink, 0, 100);
        }

        public override void Eat()
        {
            if (Global.FoodAmount[$"{FoodName}"] <= 0)
                return;
            Global.FoodAmount[$"{FoodName}"]--;

            food += 15;
            food = Math.Clamp(food, 0, 100);
        }

        public override void Sleep()
        {
            sleep += 7;
            sleep = Math.Clamp(sleep, 0, 100);
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}

