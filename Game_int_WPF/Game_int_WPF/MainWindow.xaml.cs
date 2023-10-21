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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game_int_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation dblAnim = new DoubleAnimation();
            dblAnim.From = 0.0;
            dblAnim.To = 1;
            dblAnim.Duration = new Duration(TimeSpan.FromMilliseconds(8000));
            image_button_exit.BeginAnimation(Image.OpacityProperty, dblAnim);
        }

        private void image_button_exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Intro_MediaEnded(object sender, RoutedEventArgs e)
        {
            Intro.Position = new TimeSpan(0, 0, 1);
            Intro.Play();
        }
    }

}
