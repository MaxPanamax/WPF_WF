namespace Домашка_калькулятор
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();   
        }
        float a, b;
        int count;
        bool znak=true;
        private void Calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(Экран.Text);
                    Экран.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(Экран.Text);
                    Экран.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(Экран.Text);
                    Экран.Text = b.ToString();
                    break;
                case 4:
                    float divider;
                    divider = float.Parse(Экран.Text);
                    if (divider == 0.0)
                        MessageBox.Show("Внимание! Деление на ноль!");
                    else
                    {
                        b = a / divider;
                        Экран.Text = b.ToString();
                    }
                    break;
                case 5:
                    b = a *100/ float.Parse(Экран.Text);
                    Экран.Text = b.ToString();
                    break;
                default:
                    break;
            }

        }
        private void Кнопка_0_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 0;
        }

        private void Кнопка_1_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 1;
        }

        private void Кнопка_2_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 2;
        }

        private void Кнопка_3_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 3;
        }

        private void Кнопка_4_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 4;
        }

        private void Кнопка_5_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 5;
        }

        private void Кнопка_6_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 6;
        }

        private void Кнопка_7_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 7;
        }

        private void Кнопка_8_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 8;
        }

        private void Кнопка_9_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + 9;
        }

        private void Кнопка_плюс_Click(object sender, EventArgs e)
        {
            a = float.Parse(Экран.Text);
            Экран.Clear();
            count = 1;
            Экран_2.Text = a.ToString() + "+";
            znak = true;
        }

        private void Кнопка_минус_Click(object sender, EventArgs e)
        {
            a = float.Parse(Экран.Text);
            Экран.Clear();
            count = 2;
            Экран_2.Text = a.ToString() + "-";
            znak = true;
        }

        private void Кнопка_умножить_Click(object sender, EventArgs e)
        {
            a = float.Parse(Экран.Text);
            Экран.Clear();
            count = 3;
            Экран_2.Text = a.ToString() + "*";
            znak = true;
        }

        private void Кнопа_делить_Click(object sender, EventArgs e)
        {
            a = float.Parse(Экран.Text);
            Экран.Clear();
            count = 4;
            Экран_2.Text = a.ToString() + "/";
            znak = true;
        }

        private void Кнопка_равно_Click(object sender, EventArgs e)
        {
            Calculate();
            Экран_2.Text = "";
        }

        private void Кнопка_С_Click(object sender, EventArgs e)
        {
            Экран.Text = "";
            Экран_2.Text = "";
        }

        private void Кнопка_удалить_Click(object sender, EventArgs e)
        {
            int lenght = Экран.Text.Length - 1;
            string text = Экран.Text;
            Экран.Clear();
            for (int i = 0; i < lenght; i++)
            {
                Экран.Text = Экран.Text + text[i];
            }
        }

        private void Кнопка_знак_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                Экран.Text = "-" + Экран.Text;
                znak = false;
            }
            else if (znak == false)
            {
                Экран.Text = Экран.Text.Replace("-", "");
                znak = true;
            }
        }

        private void Кнопка_процент_Click(object sender, EventArgs e)
        {
            a = float.Parse(Экран.Text);
            Экран.Clear();
            count = 5;
            Экран_2.Text = a.ToString() + "%";
            znak = true;
        }

        private void Кнопка_точка_Click(object sender, EventArgs e)
        {
            Экран.Text = Экран.Text + ",";
        }
    }
}