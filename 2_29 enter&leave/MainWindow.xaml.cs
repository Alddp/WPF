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

namespace _2_29_enter_leave
{

    public partial class MainWindow : Window
    {
        private int clickCount = 0;

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            clickCount++;
            times_count.Text = $"您已经来过{clickCount}次了";
            MessageBox.Show("欢迎光临!");

        }

        private void But1_MouseEnter(object sender, MouseEventArgs e)
        {
            but1.Content = "您来啦";
            
        }

        private void But1_MouseLeave(object sender, MouseEventArgs e)
        {
            but1.Content = "您慢走";
        }
        private void but(object sender, MouseEventArgs e)
        {
            but1.Content = "您慢走";
        }

        
    }
}
