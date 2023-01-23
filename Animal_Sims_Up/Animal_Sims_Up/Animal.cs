using System.Diagnostics;
using System.Windows.Controls;
using System;
using System.Windows;

namespace Animal_Sims_Up
{
    public abstract class Animal
    {
        public string? Name;
        public int Age;
        public int Slot;
        public string? FoodName;
        public string? Source;
        public double food = 100;
        public double drink = 100;
        public double sleep = 100;
        public double health = 100;
        public abstract void Drink();
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Speak();
        public bool Alive()
        {
            if (health >= 1)
                return true;
            else
                return false;
        }
        public void Logic()
        {
            food = Math.Clamp(food - 1, 0, 100);
            drink = Math.Clamp(drink - 1, 0, 100);
            sleep = Math.Clamp(sleep - 1, 0, 100);

            ((ProgressBar)Global.GamePage.FindName($"EatBar{Slot}")).Value = food;
            ((ProgressBar)Global.GamePage.FindName($"DrinkBar{Slot}")).Value = drink;
            ((ProgressBar)Global.GamePage.FindName($"SleepBar{Slot}")).Value = sleep;

            health = Math.Min(100, Math.Max(0, (food + drink + sleep - 100) * 0.5));
            Trace.WriteLine($"Food:{food}, Drink:{drink}, Sleep:{sleep}, Health:{health}");
            ((ProgressBar)Global.GamePage.FindName($"HealthBar{Slot}")).Value = health;
        }
    }
}
