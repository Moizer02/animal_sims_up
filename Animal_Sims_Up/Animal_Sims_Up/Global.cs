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
        public static Dictionary<int, Animal> AnimalDict = new();
        public static Dictionary<string, string> FoodNames = new();
        public static DispatcherTimer? GameTimer;
        //"Fish",
        //"Wheat",
        //"Leaf",
        //"Banana",
        //"Beef"
    }
}
