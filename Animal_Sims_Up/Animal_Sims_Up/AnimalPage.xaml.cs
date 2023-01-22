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
using System.Reflection;
using System.Diagnostics;

namespace Animal_Sims_Up
{
    /// <summary>
    /// Interaktionslogik für AnimalPage.xaml
    /// </summary>
    public partial class AnimalPage : Page
    {
        private int slot;
        public AnimalPage(int _slot)
        {
            InitializeComponent();
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(Animal))))
                AnimalDropdown.Items.Add(item.ToString().Replace("Animal_Sims_Up.", ""));
            slot = _slot;
        }
        private bool CreateIsValid()
        {
            if (AnimalDropdown.SelectedValue is null)
                return false;
            if (NameBox.Text.Length <= 0)
                return false;
            return true;
        }

        private void AnimalDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get Class Name Type and change maximum value of Slider to MaxAge
            Type classType = Type.GetType($"{typeof(Global).Namespace}.{AnimalDropdown.SelectedValue}");
            FieldInfo fi = classType.GetField("MaxAge");
            AgeSlider.Maximum = (int)fi.GetValue(null);

            if (CreateIsValid())
                CreateAnimal.IsEnabled = true;
            else
                CreateAnimal.IsEnabled = false;
        }

        private void CreateAnimal_Click(object sender, RoutedEventArgs e)
        {
            Type selectedType = Type.GetType($"{typeof(Global).Namespace}.{AnimalDropdown.Text}");
            Trace.WriteLine($"Du hast das Tier {selectedType.Name} mit dem Namen {NameBox.Text} und dem Alter {AgeSlider.Value} ausgewählt");
            switch (selectedType.Name)
            {
                case nameof(Lion):
                    Global.AnimalDict.Add(slot, new Lion(NameBox.Text, (int)AgeSlider.Value));
                    break;
                case nameof(Monkey):
                    Global.AnimalDict.Add(slot, new Monkey(NameBox.Text, (int)AgeSlider.Value));
                    break;
                case nameof(Bear):
                    Global.AnimalDict.Add(slot, new Bear(NameBox.Text, (int)AgeSlider.Value, slot));
                    break;
                case nameof(Giraffe):
                    Global.AnimalDict.Add(slot, new Giraffe(NameBox.Text, (int)AgeSlider.Value));
                    break;
                case nameof(Pig):
                    Global.AnimalDict.Add(slot, new Pig(NameBox.Text, (int)AgeSlider.Value));
                    break;
                default:
                    break;
            }
            Global.GamePage.GameGrid.Visibility = Visibility.Visible;
            Global.MainWindow.NavigationFrame.Content = Global.GamePage;
            ((Button)Global.GamePage.FindName($"AnimalButton{slot}")).Visibility = Visibility.Collapsed;
            ((Grid)Global.GamePage.FindName($"AnimalGrid{slot}")).Visibility = Visibility.Visible;
            ((Image)Global.GamePage.FindName(($"AnimalImage{slot}"))).Source = new BitmapImage(new Uri($"pack://application:,,,/{selectedType.Name.ToLower()}.png"));
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CreateIsValid())
                CreateAnimal.IsEnabled = true;
            else
                CreateAnimal.IsEnabled = false;
        }
    }
}
