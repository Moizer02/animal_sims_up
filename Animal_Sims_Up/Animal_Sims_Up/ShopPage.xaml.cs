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

namespace Animal_Sims_Up
{
    /// <summary>
    /// Interaktionslogik für ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public ShopPage()
        {
            InitializeComponent();
        }
        public bool EnoughMoney(int _price)
        {
            if (_price <= Global.Currency)
                return true;
            else
                return false;
        }

        private void ButtonBuyWater_Click(object sender, RoutedEventArgs e)
        {
            if (EnoughMoney(1))
            {
                Global.Currency--;
                Global.FoodAmount["Water"]++;
            }
        }

        private void ButtonBuyFish_Click(object sender, RoutedEventArgs e)
        {
            if (EnoughMoney(1))
            {
                Global.Currency--;
                Global.FoodAmount["Fish"]++;
            }
        }

        private void ButtonBuyBeef_Click(object sender, RoutedEventArgs e)
        {
            if (EnoughMoney(1))
            {
                Global.Currency--;
                Global.FoodAmount["Beef"]++;
            }
        }

        private void ButtonBuyBanana_Click(object sender, RoutedEventArgs e)
        {
            if (EnoughMoney(1))
            {
                Global.Currency--;
                Global.FoodAmount["Banana"]++;
            }
        }

        private void ButtonBuyWheat_Click(object sender, RoutedEventArgs e)
        {
            if (EnoughMoney(1))
            {
                Global.Currency--;
                Global.FoodAmount["Wheat"]++;
            }
        }

        private void ButtonBuyLeaf_Click(object sender, RoutedEventArgs e)
        {
            if (EnoughMoney(1))
            {
                Global.Currency--;
                Global.FoodAmount["Leaf"]++;
            }
        }
    }
}
