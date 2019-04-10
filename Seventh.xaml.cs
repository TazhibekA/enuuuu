using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace ENUPRRESH
{
    /// <summary>
    /// Логика взаимодействия для Seventh.xaml
    /// </summary>
    public partial class Seventh : Window
    {
        public Seventh()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            r1.Clear();
            r2.Clear();
            r3.Clear();
            r4.Clear();

            double a1Int = double.Parse(a1.Text, CultureInfo.InvariantCulture);
            double a2Int = double.Parse(a2.Text, CultureInfo.InvariantCulture);
            double a3Int = double.Parse(a3.Text, CultureInfo.InvariantCulture);
            double a4Int = double.Parse(a4.Text, CultureInfo.InvariantCulture);
            double a5Int = double.Parse(a5.Text, CultureInfo.InvariantCulture);
            double a6Int = double.Parse(a6.Text, CultureInfo.InvariantCulture);

            double r1Int = a1Int + a2Int + ((a3Int * ((100 - a4Int)/100)));
            double r2Int = r1Int + a5Int;
            double r3Int = r1Int;
            double r4Int = (r3Int * ((100 - a6Int) / 100))  ;


            r1.Text = r1Int.ToString();
            r2.Text = r2Int.ToString();
            r3.Text = r3Int.ToString();
            r4.Text = r4Int.ToString();

        }
    }
}
