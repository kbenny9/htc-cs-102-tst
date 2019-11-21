using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace InterfacesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<IWalker> Animals;

        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<IWalker>();

            // make siome aminals
            Frog frog = new Frog(4,"Bart",true, 8, 5, 5.5);
            Dog dog = new Dog("Labradoodle", 35, "Pax", 6, 5, 2.0);
            Duck duck = new Duck(4, "Moo", 4, 5, 3.4);
            StarWarsRobot C3PO = new StarWarsRobot(9, 9, 8.5);

            Animals.Add(frog);
            Animals.Add(dog);
            Animals.Add(duck);
            Animals.Add(C3PO);

            lvAnimals.ItemsSource = Animals;
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (IWalker a in Animals)
            {
                a.walk();
            }
        }

		private void LvAnimals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			IWalker selectedAnimal = lvAnimals.SelectedItem as IWalker;
			if (selectedAnimal != null)
			{
				selectedAnimal.walk();
			}
		}
	}
}
