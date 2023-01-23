using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Animal_Sims_Up
{
    internal class Bear : Animal
    {
        public Bear(string _name, int _age, int _slot)
        {
            Name = _name;
            Age = _age;
            Slot = _slot;
            FoodName = "Fish";
        }
        public static int MaxAge = 25;

        public override void Drink()
        {
            if (Global.FoodAmount["Water"] <= 0)
                return;
            Global.FoodAmount["Water"]--;

            drink += 20;
            drink = Math.Clamp(drink, 0, 100);
        }

        public override void Eat()
        {
            if (Global.FoodAmount[$"{FoodName}"] <= 0)
                return;
            Global.FoodAmount[$"{FoodName}"]--;

            food += 25;
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
