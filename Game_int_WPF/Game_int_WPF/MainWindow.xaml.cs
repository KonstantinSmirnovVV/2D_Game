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

        private void El_Cntrl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            El_music.Background.Opacity = 0;
            El_Cntrl.Background.Opacity = 100;

            lb_up.Visibility = Visibility.Visible;
            lb_left.Visibility = Visibility.Visible;
            lb_right.Visibility = Visibility.Visible;
            lb_fire.Visibility = Visibility.Visible;
            lb_jump.Visibility = Visibility.Visible;

            cntrl_up.Visibility = Visibility.Visible;
            cntrl_left.Visibility = Visibility.Visible;
            cntrl_right.Visibility = Visibility.Visible;
            cntrl_fire.Visibility = Visibility.Visible;
            cntrl_jump.Visibility = Visibility.Visible;

            lb_total_volume.Visibility = Visibility.Collapsed;
            sld_total_volume.Visibility = Visibility.Collapsed;
            tb_percent_total_volume.Visibility = Visibility.Collapsed;
            lb_music.Visibility = Visibility.Collapsed;
            sld_music.Visibility = Visibility.Collapsed;
            tb_percent_music.Visibility = Visibility.Collapsed;
            lb_sound_effects.Visibility = Visibility.Collapsed;
            sld_sound_effects.Visibility = Visibility.Collapsed;
            tb_percent_sound_effects.Visibility = Visibility.Collapsed;


        }

        private void El_music_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            El_music.Background.Opacity = 100;
            El_Cntrl.Background.Opacity = 0;

            lb_up.Visibility = Visibility.Collapsed;
            lb_left.Visibility = Visibility.Collapsed;
            lb_right.Visibility = Visibility.Collapsed;
            lb_fire.Visibility = Visibility.Collapsed;
            lb_jump.Visibility = Visibility.Collapsed;

            cntrl_up.Visibility = Visibility.Collapsed;
            cntrl_left.Visibility = Visibility.Collapsed;
            cntrl_right.Visibility = Visibility.Collapsed;
            cntrl_fire.Visibility = Visibility.Collapsed;
            cntrl_jump.Visibility = Visibility.Collapsed;

            lb_total_volume.Visibility = Visibility.Visible;
            sld_total_volume.Visibility = Visibility.Visible;
            tb_percent_total_volume.Visibility = Visibility.Visible;
            lb_music.Visibility = Visibility.Visible;
            sld_music.Visibility = Visibility.Visible;
            tb_percent_music.Visibility = Visibility.Visible;
            lb_sound_effects.Visibility = Visibility.Visible;
            sld_sound_effects.Visibility = Visibility.Visible;
            tb_percent_sound_effects.Visibility = Visibility.Visible;
        }
    }

}
