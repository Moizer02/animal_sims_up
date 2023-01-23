using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaktionslogik für ManageAnimal.xaml
    /// </summary>
    public partial class ManageAnimal : Page
    {
        private int slot;
        Animal? animal;
        public ManageAnimal(int _slot)
        {
            InitializeComponent();
            slot = _slot;
            animal = Global.AnimalDict[slot];
            AnimalImage.Source = new BitmapImage(new Uri(animal.Source));
            AnimalInfo.Text = $"Name: {animal.Name}\r\nAge: {animal.Age}";
        }

        public void Update()
        {
            EatBar.Value = animal.food;
            DrinkBar.Value = animal.drink;
            SleepBar.Value = animal.sleep;
            HealthBar.Value = animal.health;
        }

        private void Feed_Click(object sender, RoutedEventArgs e)
        {
            animal.Eat();
        }

        private void Water_Click(object sender, RoutedEventArgs e)
        {
            animal.Drink();
        }

        private void Sleep_Click(object sender, RoutedEventArgs e)
        {
            animal.Sleep();
        }
    }
}
