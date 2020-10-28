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

namespace The_Next_Car
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("start button");
        }

        private void DoorOpenButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("door open button");
        }

        private void LoockDoorButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("lock door button");
        }

        private void AccuButton_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("accu button");
        }
    }
}
