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
using System.Windows.Shapes;

namespace ENUPRRESH
{
    /// <summary>
    /// Логика взаимодействия для First.xaml
    /// </summary>
    public partial class First : Window
    {
        public First()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            res.Clear();
            if (!String.IsNullOrEmpty(vvod1.Text) && !String.IsNullOrEmpty(vvod2.Text) && !String.IsNullOrEmpty(vvod3.Text) && !String.IsNullOrEmpty(vvod4.Text)
        && !String.IsNullOrEmpty(vyvod1.Text) && !String.IsNullOrEmpty(vyvod2.Text) && !String.IsNullOrEmpty(vyvod3.Text) && !String.IsNullOrEmpty(vyvod4.Text)
        && !String.IsNullOrEmpty(m.Text))
            {
                int mInt = int.Parse(m.Text);
                int month1Int = int.Parse(month1.Text);
                int month2Int = int.Parse(month2.Text);
                int month3Int = int.Parse(month3.Text);
                int month4Int = int.Parse(month4.Text);
                int vvod1Int = int.Parse(vvod1.Text);
                int vvod2Int = int.Parse(vvod2.Text);
                int vvod3Int = int.Parse(vvod3.Text);
                int vvod4Int = int.Parse(vvod4.Text);
                int vyvod1Int = int.Parse(vyvod1.Text);
                int vyvod2Int = int.Parse(vyvod2.Text);
                int vyvod3Int = int.Parse(vyvod3.Text);
                int vyvod4Int = int.Parse(vyvod4.Text);
                int resInt = mInt + ((vvod1Int * month1Int) / 12) + ((vvod2Int * month2Int) / 12) + ((vvod3Int * month3Int) / 12) + ((vvod4Int * month4Int) / 12) -
                    ((vyvod1Int * month1Int) / 12)- ((vyvod2Int * month2Int) / 12) - ((vyvod3Int * month3Int) / 12)- ((vyvod4Int * month4Int) / 12);

                res.Text = resInt.ToString();

            }
        }
    }
}
