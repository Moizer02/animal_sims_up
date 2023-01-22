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
            //Global.GameTimer.Interval = TimeSpan.FromSeconds(3);
            Global.GameTimer.Interval = TimeSpan.FromMilliseconds(400);
            Global.GameTimer.Tick += GameTick;
            Global.GameTimer.Start();
        }
        private void GameTick(object sender, EventArgs e)
        {
            foreach (var item in Global.AnimalDict)
            {
                item.Value.Logic();
            }
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
    }
}
