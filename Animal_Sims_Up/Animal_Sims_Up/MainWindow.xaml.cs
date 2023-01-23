using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Animal_Sims_Up
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NavigationFrame.Content = Global.GamePage;
            Global.MainWindow = this;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Game_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Content = Global.GamePage;
            Global.GamePage.GameGrid.Visibility = Visibility.Visible;
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            NavigationFrame.Content = new ShopPage();
        }
    }
}
