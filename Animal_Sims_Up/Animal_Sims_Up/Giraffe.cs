using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sims_Up
{
    internal class Giraffe : Animal
    {
        public Giraffe(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
        public static int MaxAge = 30;

        public override void Sleep()
        {
            sleep += 1;
        }

        public override void Drink()
        {
            drink += 20;
            Math.Clamp(drink, 0, 100);
        }

        public override void Eat()
        {
            if (FoodAmount <= 0)
                return;

            food += 20;
            Math.Clamp(food, 0, 100);

            FoodAmount -= 1;
        }
        public override void Speak()
        {
            throw new NotImplementedException();
        }

        public override void Logic()
        {
            throw new NotImplementedException();
        }
    }
}
