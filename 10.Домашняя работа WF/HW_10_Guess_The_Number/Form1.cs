using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_10_Guess_The_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Hide();
            int min = 1, max = 2000;
            int tmp;
            for (int i = 1; ; i++)
            {
                tmp = (min + max) / 2;
                DialogResult res = MessageBox.Show($"Загаданное вами число - {tmp}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    MessageBox.Show($"Потребовалось запросов {i}");
                    textBox1.Show();
                    textBox1.Text = $"Потребовалось запросов - {i}";
                    break;
                }
                else
                {
                    res = MessageBox.Show($"Загаданное вами число больше {tmp}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        min = tmp + 1;
                    }
                    else
                    {
                        max = tmp - 1;
                    }
                }
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

            label1.BackColor = Color.DeepPink;
            label1.ForeColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepPink;
            button1.ForeColor = Color.White;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
