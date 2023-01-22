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
            //Global.FoodNames.Add("Bear", "Fish");
        }
        public static int MaxAge = 25;

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
            food--;
            drink--;
            sleep--;

            ((ProgressBar)Global.GamePage.FindName($"EatBar{Slot}")).Value = food;
            ((ProgressBar)Global.GamePage.FindName($"DrinkBar{Slot}")).Value = drink;
            ((ProgressBar)Global.GamePage.FindName($"SleepBar{Slot}")).Value = sleep;

            health = Math.Min(100, Math.Max(0, (food + drink + sleep - 100) * 0.5));
            Trace.WriteLine($"Food:{food}, Drink:{drink}, Sleep:{sleep}, Health:{health}");
            ((ProgressBar)Global.GamePage.FindName($"HealthBar{Slot}")).Value = health;
        }
    }
}
