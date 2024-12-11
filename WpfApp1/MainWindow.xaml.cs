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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            
            // button.Visibility = Visibility.Hidden;

            DoubleAnimation widthAnimation = new DoubleAnimation
            {
                From = button.ActualWidth,
                To = 0,
                Duration = new Duration(TimeSpan.FromSeconds(3)),
            };
            button.BeginAnimation(Button.WidthProperty, widthAnimation);
        }




    }
}
