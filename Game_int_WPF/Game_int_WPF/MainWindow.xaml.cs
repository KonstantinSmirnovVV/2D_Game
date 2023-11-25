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
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation dblAnim = new DoubleAnimation();
            dblAnim.From = 0.0;
            dblAnim.To = 0.91;
            dblAnim.Duration = new Duration(TimeSpan.FromMilliseconds(8000));
            image_button_exit.BeginAnimation(Image.OpacityProperty, dblAnim);
            Nickname.BeginAnimation(Label.OpacityProperty, dblAnim);
            Avatar.BeginAnimation(Image.OpacityProperty, dblAnim);
            Name_game.BeginAnimation(Image.OpacityProperty, dblAnim);
            Setting.BeginAnimation(Image.OpacityProperty, dblAnim);
            Start_game.BeginAnimation(Image.OpacityProperty, dblAnim);

        }

        private void image_button_exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Intro_MediaEnded(object sender, RoutedEventArgs e)
        {
            // Intro.Position = new TimeSpan(0, 0, 1);
            //Intro.Play();


            Intro.Stop();
            Intro.Visibility = Visibility.Collapsed;

            Intro_2.Position = new TimeSpan(0, 0, 0);
            Intro_2.Play();
            Intro_2.Visibility = Visibility.Visible;
        }

        private void Intro_2_MediaEnded(object sender, RoutedEventArgs e)
        {
            Intro_2.Position = new TimeSpan(0, 0, 0);
            Intro_2.Play();
        }

        private void Intro_2_MediaOpened(object sender, RoutedEventArgs e)
        {

        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            Music_intro.Position = new TimeSpan(0,0,0);
            Music_intro.Play();
        }

        private void Music_intro_MediaOpened(object sender, RoutedEventArgs e)
        {
            Music_intro.Volume = 0.4;

        }

        private void Setting_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Setting_Window.Visibility = Visibility.Visible;
            image_button_exit.Visibility = Visibility.Collapsed;
            Setting.Visibility = Visibility.Collapsed;
            Start_game.Visibility = Visibility.Collapsed;
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Setting_Window.Visibility = Visibility.Collapsed;
            image_button_exit.Visibility = Visibility.Visible;
            Setting.Visibility = Visibility.Visible;
            Start_game.Visibility = Visibility.Visible;
        }
    }

}
