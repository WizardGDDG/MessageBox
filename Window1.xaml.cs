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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        int num = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(num));
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            num++;
            lab.Content = random.Next(1, 2000).ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            
            lab.Content = random.Next(1, 2000).ToString();
        }
    }
}
