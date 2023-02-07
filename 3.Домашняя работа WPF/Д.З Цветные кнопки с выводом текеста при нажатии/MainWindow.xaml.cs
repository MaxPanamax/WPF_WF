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

        private void Navy_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Navy;
            Scoreboard.Text = "Цвет Navy";
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Blue;
            Scoreboard.Text = "Цвет Blue";
        }

        private void Teal_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Teal;
            Scoreboard.Text = "Цвет Teal";
        }

        private void Olive_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Olive;
            Scoreboard.Text = "Цвет Olive";
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Green;
            Scoreboard.Text = "Цвет Green";
        }

        private void Lime_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Lime;
            Scoreboard.Text = "Цвет Lime";
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Yellow;
            Scoreboard.Text = "Цвет Yellow";
        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Orange;
            Scoreboard.Text = "Цвет Orange";
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Red;
            Scoreboard.Text = "Цвет Red";
        }

        private void Maroon_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Maroon;
            Scoreboard.Text = "Цвет Maroon";
        }

        private void Fuchsia_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Fuchsia;
            Scoreboard.Text = "Цвет Fuchsia";
        }

        private void Purpule_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Purple;
            Scoreboard.Text = "Цвет Purple";
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Black;
            Scoreboard.Text = "Цвет Black";
        }

        private void Silver_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Silver;
            Scoreboard.Text = "Цвет Silver";
        }

        private void Gray_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.Gray;
            Scoreboard.Text = "Цвет Gray";
        }

        private void White_Click(object sender, RoutedEventArgs e)
        {
            Scoreboard.Foreground = Brushes.White;
            Scoreboard.Text = "Цвет White";
        }
    }
}
