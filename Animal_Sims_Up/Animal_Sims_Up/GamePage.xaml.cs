using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Animal_Sims_Up
{
    /// <summary>
    /// Interaktionslogik für GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {

        public GamePage()
        {
            InitializeComponent();
            DispatcherTimer t = new();
            Global.GameTimer = t;
            Global.GameTimer.Interval = TimeSpan.FromMilliseconds(500);
            Global.GameTimer.Tick += GameTick;
            Global.GameTimer.Start();
        }
        private void GameTick(object sender, EventArgs e)
        {
            Random r = new();
            if (r.Next(0, 5) == 3)
                Global.Currency++;

            foreach (var item in Global.FoodAmount)
            {
                ((TextBlock)Global.MainWindow.FindName($"{item.Key}Amount")).Text = $"{item.Key}: {item.Value}";
            }

            ((TextBlock)Global.MainWindow.FindName($"CurrencyAmount")).Text = $"Currency: {Global.Currency}";

            foreach (var item in Global.AnimalDict)
            {
                if (item.Value.Alive())
                    item.Value.Logic();
                else
                {
                    ((Image)FindName($"AnimalImage{item.Value.Slot}")).Source = null;
                    ((ProgressBar)FindName($"EatBar{item.Value.Slot}")).Value = 100;
                    ((ProgressBar)FindName($"DrinkBar{item.Value.Slot}")).Value = 100;
                    ((ProgressBar)FindName($"SleepBar{item.Value.Slot}")).Value = 100;
                    ((ProgressBar)FindName($"HealthBar{item.Value.Slot}")).Value = 100;
                    ((Grid)FindName($"AnimalGrid{item.Value.Slot}")).Visibility = Visibility.Collapsed;
                    ((Grid)FindName($"AnimalInfo{item.Value.Slot}")).Visibility = Visibility.Collapsed;
                    ((Button)FindName($"AnimalButton{item.Value.Slot}")).Visibility = Visibility.Visible;
                    MessageBox.Show($"Your Animal '{item.Value.Name}' died with the age of '{item.Value.Age}' :(");
                    Global.AnimalDict.Remove(item.Key);
                    Global.MainWindow.NavigationFrame.Content = Global.GamePage;
                }
            }

            try
            {
                Global.manageAnimal.Update();
            }
            catch { }
        }
        private void AnimalButton1_Click(object sender, RoutedEventArgs e)
        {
            Global.GamePage.GameGrid.Visibility = System.Windows.Visibility.Collapsed;
            Global.MainWindow.NavigationFrame.Content = new AnimalPage(1);
        }

        private void AnimalButton2_Click(object sender, RoutedEventArgs e)
        {
            Global.GamePage.GameGrid.Visibility = System.Windows.Visibility.Collapsed;
            Global.MainWindow.NavigationFrame.Content = new AnimalPage(2);
        }

        private void AnimalButton3_Click(object sender, RoutedEventArgs e)
        {
            Global.GamePage.GameGrid.Visibility = System.Windows.Visibility.Collapsed;
            Global.MainWindow.NavigationFrame.Content = new AnimalPage(3);
        }

        private void AnimalButton4_Click(object sender, RoutedEventArgs e)
        {
            Global.GamePage.GameGrid.Visibility = System.Windows.Visibility.Collapsed;
            Global.MainWindow.NavigationFrame.Content = new AnimalPage(4);
        }

        private void ManageAnimal1_Click(object sender, RoutedEventArgs e)
        {
            ManageAnimal m = new(1);
            Global.manageAnimal = m;
            Global.MainWindow.NavigationFrame.Content = m;
        }

        private void ManageAnimal2_Click(object sender, RoutedEventArgs e)
        {
            ManageAnimal m = new(2);
            Global.manageAnimal = m;
            Global.MainWindow.NavigationFrame.Content = m;
        }

        private void ManageAnimal3_Click(object sender, RoutedEventArgs e)
        {
            ManageAnimal m = new(3);
            Global.manageAnimal = m;
            Global.MainWindow.NavigationFrame.Content = m;
        }

        private void ManageAnimal4_Click(object sender, RoutedEventArgs e)
        {
            ManageAnimal m = new(4);
            Global.manageAnimal = m;
            Global.MainWindow.NavigationFrame.Content = m;
        }
    }
}
