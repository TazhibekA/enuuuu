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

namespace ENUPRRESH
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        First firstWindow = new First();
        Second secondWindow = new Second();
        Third thirdWindow = new Third();
        Fourth fourthWindow = new Fourth();
        fifth fifthWindow = new fifth();
        Sixth sixthWindow = new Sixth();
        Seventh seventhWindow = new Seventh();
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            firstWindow.Show();
 
        }

        private void Second_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Third_Click(object sender, RoutedEventArgs e)
        {
            thirdWindow.Show();
        }

        private void Fourth_Click(object sender, RoutedEventArgs e)
        {
            fourthWindow.Show();
        }

        private void Fifth_Click(object sender, RoutedEventArgs e)
        {
            fifthWindow.Show();
        }

        private void Sixth_Click(object sender, RoutedEventArgs e)
        {
            sixthWindow.Show();
        }

        private void Seventh_Click(object sender, RoutedEventArgs e)
        {
            seventhWindow.Show();
        }
    }
}
