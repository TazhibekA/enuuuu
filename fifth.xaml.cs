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
    /// Логика взаимодействия для fifth.xaml
    /// </summary>
    public partial class fifth : Window
    {
        public fifth()
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
            r9.Clear();
            r10.Clear();
            r11.Clear();
            r12.Clear();
            r13.Clear();
            r14.Clear();

            int a1Int = int.Parse(a1.Text);
            int a2Int = int.Parse(a2.Text);
            int a3Int = int.Parse(a3.Text);
            int a4Int = int.Parse(a4.Text);
            int a5Int = int.Parse(a5.Text);
            int a6Int = int.Parse(a6.Text);
            int a7Int = int.Parse(a7.Text);

            int b1Int = int.Parse(b1.Text);
            int b2Int = int.Parse(b2.Text);
            int b3Int = int.Parse(b3.Text);
            int b4Int = int.Parse(b4.Text);
            int b5Int = int.Parse(b5.Text);
            int b6Int = int.Parse(b6.Text);
            int b7Int = int.Parse(b7.Text);

            int r1Int = a1Int * a2Int;
            int r2Int = b1Int * b2Int;
            r1.Text = r1Int.ToString();
            r2.Text = r2Int.ToString();

            int rr = a3Int + ((a3Int * a4Int) / 100);
            int rr1 = b3Int + ((b3Int * b4Int) / 100);

            int r3Int = rr + ((rr * a5Int) / 100);
            int r4Int = rr1 + ((rr1 * b5Int) / 100);
            r3.Text = r3Int.ToString();
            r4.Text = r4Int.ToString();

            int r5Int = r1Int + r3Int;
            int r6Int = r2Int + r4Int;
            r5.Text = r5Int.ToString();
            r6.Text = r6Int.ToString();

            double r7Int = (r5Int *  a6Int) / 100;
            double r8Int =  (r6Int *  b6Int) / 100;
            r7.Text = r7Int.ToString();
            r8.Text = r8Int.ToString();

            double r9Int = r5Int + r7Int;
            double r10Int = r6Int + r8Int;
            r9.Text = r9Int.ToString();
            r10.Text = r10Int.ToString();

            double r11Int =  (r9Int *  a7Int) / 100;
            double r12Int =  (r10Int * b7Int) / 100;
            r11.Text = r10Int.ToString();
            r12.Text = r11Int.ToString();

            double r13Int = r9Int + r11Int;
            double r14Int = r10Int + r12Int;
            r13.Text = r13Int.ToString();
            r14.Text = r14Int.ToString();




        }
    }
}
