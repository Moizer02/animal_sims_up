using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Animal_Sims_Up
{
    internal class Global
    {
        public static MainWindow? MainWindow;
        public static GamePage GamePage = new();
        public static ManageAnimal? manageAnimal;
        public static Dictionary<int, Animal> AnimalDict = new();
        public static Dictionary<string, int> FoodAmount = new()
        {
            {"Water", 0},
            {"Fish", 0},
            {"Beef", 0},
            {"Banana", 0},
            {"Wheat", 0},
            {"Leaf", 0},
        };
        public static DispatcherTimer? GameTimer;

        public static int Currency = 10;
    }
}
