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
        Button btn1, btn2;
        int moves = 0, cardsshow=0, count=4;

        private void to_start_the_game_Click(object sender, RoutedEventArgs e)
        {
            Button start = sender as Button;
            to_start_the_game.Visibility = Visibility.Collapsed;
        }

        public MainWindow()
        {
            InitializeComponent();
 
            
        }
        private void BtnClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            moves++;
            btn.Visibility = Visibility.Collapsed;//לחשוף את הקךף שנלחץ
            if (btn1 == null)
            {
                btn1 = btn;//save the first card
            }
            else
            {
                if(btn2 == null)// chack if it is the second card
                {
                    btn2 = btn;//save the second card
                    if (count == cardsshow + 1)//the game is over?
                    {
                        MessageBox.Show($"כל הכבוד נצחת ב {moves} מהלכים!!!!!!");
                    }
                }
                else
                {

                    if (btn1.Tag.ToString()==btn2.Tag.ToString())
                    {
                        cardsshow += 1;
                    }
                    else
                    {
                        btn1.Visibility = Visibility.Visible;
                        btn2.Visibility = Visibility.Visible;
                    } 
                    btn1 = btn;
                    btn2 = null;//we don't heve scond card
                }
            }
        }




    }
}
