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
    /// Логика взаимодействия для Third.xaml
    /// </summary>
    public partial class Third : Window
    {
        public Third()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            res.Clear();
            f1.Clear();
            f2.Clear();
            if (!String.IsNullOrEmpty(vvod1.Text) && !String.IsNullOrEmpty(vvod2.Text) && !String.IsNullOrEmpty(vvod3.Text) && !String.IsNullOrEmpty(vvod4.Text)
       && !String.IsNullOrEmpty(vyvod1.Text) && !String.IsNullOrEmpty(vyvod2.Text) && !String.IsNullOrEmpty(vyvod3.Text) && !String.IsNullOrEmpty(vyvod4.Text)
       && !String.IsNullOrEmpty(m.Text))
            {
                double mInt = double.Parse(m.Text, CultureInfo.InvariantCulture);
                double sInt = double.Parse(s.Text, CultureInfo.InvariantCulture);
                double month1Int = double.Parse(month1.Text, CultureInfo.InvariantCulture);
                double month2Int = double.Parse(month2.Text, CultureInfo.InvariantCulture);
                double month3Int = double.Parse(month3.Text, CultureInfo.InvariantCulture);
                double month4Int = double.Parse(month4.Text, CultureInfo.InvariantCulture);
                double vvod1Int = double.Parse(vvod1.Text, CultureInfo.InvariantCulture);
                double vvod2Int = double.Parse(vvod2.Text, CultureInfo.InvariantCulture);
                double vvod3Int = double.Parse(vvod3.Text, CultureInfo.InvariantCulture);
                double vvod4Int = double.Parse(vvod4.Text, CultureInfo.InvariantCulture);
                double vyvod1Int = double.Parse(vyvod1.Text, CultureInfo.InvariantCulture);
                double vyvod2Int = double.Parse(vyvod2.Text, CultureInfo.InvariantCulture);
                double vyvod3Int = double.Parse(vyvod3.Text, CultureInfo.InvariantCulture);
                double vyvod4Int = double.Parse(vyvod4.Text, CultureInfo.InvariantCulture);
                double resInt = sInt + ((vvod1Int * month1Int) / 12) + ((vvod2Int * month2Int) / 12) + ((vvod3Int * month3Int) / 12) + ((vvod4Int * month4Int) / 12) -
                    ((vyvod1Int * month1Int) / 12) - ((vyvod2Int * month2Int) / 12) - ((vyvod3Int * month3Int) / 12) - ((vyvod4Int * month4Int) / 12);
                double kk = mInt / resInt;
                double ks = resInt / mInt;
                res.Text = resInt.ToString();
                f1.Text = kk.ToString();
                f2.Text = ks.ToString();
            }
        }
    }
}
