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

namespace WpfApp2
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
        float a, b;
        int count;
        bool znak = true;
        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                case 4:
                    float divider;
                    divider = float.Parse(TextBox1.Text);
                    if (divider == 0.0)
                        MessageBox.Show("Внимание! Деление на ноль!");
                    else
                    {
                        b = a / divider;
                        TextBox1.Text = b.ToString();
                    }
                    break;
                case 5:
                    b = a / 100 * float.Parse(TextBox1.Text);
                    TextBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox_Экран_2.Text = "";
        }

        private void Button_удалить_Click(object sender, RoutedEventArgs e)
        {
            int lenght = TextBox1.Text.Length - 1;
            string text = TextBox1.Text;
            TextBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                TextBox1.Text = TextBox1.Text + text[i];
            }
        }

        private void Button_проценты_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 5;
            TextBox_Экран_2.Text = a.ToString() + "%";
            znak = true;
        }

        private void Button_отнять_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 2;
            TextBox_Экран_2.Text = a.ToString() + "-";
            znak = true;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 9;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 8;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 7;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 4;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 5;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 6;
        }

        private void Dutton_умножить_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 3;
            TextBox_Экран_2.Text = a.ToString() + "*";
            znak = true;
        }

        private void Button_делить_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 4;
            TextBox_Экран_2.Text = a.ToString() + "/";
            znak = true;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 3;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 2;
        }

        private void Buton_1_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 1;
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + 0;
        }

        private void Button_знак_Click(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                TextBox1.Text = "-" + TextBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                TextBox1.Text = TextBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_точка_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = TextBox1.Text + ",";
        }

        private void Dutton_плюс_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(TextBox1.Text);
            TextBox1.Clear();
            count = 1;
            TextBox_Экран_2.Text = a.ToString() + "+";
            znak = true;
        }

        private void Button_равно_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            TextBox_Экран_2.Text = "";
        }

        private void Button_знак_Click_1(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                TextBox1.Text = "-" + TextBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                TextBox1.Text = TextBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void TextBox_Экран_2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
