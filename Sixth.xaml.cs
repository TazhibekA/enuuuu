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
    /// Логика взаимодействия для Sixth.xaml
    /// </summary>
    public partial class Sixth : Window
    {
        public Sixth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            r1.Clear();
            r2.Clear();
            r3.Clear();
            r4.Clear();
            r5.Clear();
            r6.Clear();
            r7.Clear();
            r8.Clear();

            int a1Int = int.Parse(a1.Text);
            int a2Int = int.Parse(a2.Text);
            int a3Int = int.Parse(a3.Text);
            int a4Int = int.Parse(a4.Text);
            

            int b1Int = int.Parse(b1.Text);
            int b2Int = int.Parse(b2.Text);
            int b3Int = int.Parse(b3.Text);
            int b4Int = int.Parse(b4.Text);

            int r1Int = a2Int * a3Int;
            int r2Int = b2Int * b3Int;
            int r3Int = a2Int * a4Int;
            int r4Int = b2Int * b4Int;
            int r5Int = r1Int - r3Int;
            int r6Int = r2Int - r4Int;
            int r7Int = (r5Int*100) / r1Int;
            int r8Int = (r6Int*100) / r2Int;
            r1.Text = r1Int.ToString();
            r2.Text = r2Int.ToString();
            r3.Text = r3Int.ToString();
            r4.Text = r4Int.ToString();
            r5.Text = r5Int.ToString();
            r6.Text = r6Int.ToString();
            r7.Text = r7Int.ToString();
            r8.Text = r8Int.ToString();

        }
    }
}
