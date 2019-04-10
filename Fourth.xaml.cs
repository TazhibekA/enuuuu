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
    /// Логика взаимодействия для Fourth.xaml
    /// </summary>
    public partial class Fourth : Window
    {
        public Fourth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            res.Clear();
            k.Clear();
            if (!String.IsNullOrEmpty(tek.Text) && !String.IsNullOrEmpty(nor.Text) && !String.IsNullOrEmpty(izd.Text) && !String.IsNullOrEmpty(tr.Text)) {
                double tekInt = double.Parse(tek.Text, CultureInfo.InvariantCulture);
                double norInt = double.Parse(nor.Text, CultureInfo.InvariantCulture);
                double izdInt = double.Parse(izd.Text, CultureInfo.InvariantCulture);
                double trInt = double.Parse(tr.Text, CultureInfo.InvariantCulture);

                double rs = (norInt * izdInt) / 360;
                double tek1 = 90 * (rs);
                double str = 0.5 * tek1;
                double tr1 = rs * trInt;
                double pr = tek1 + str + tr1;
                double k1 = tekInt / norInt;

                res.Text = pr.ToString();
                k.Text = k1.ToString();
            }
        }
    }
}
