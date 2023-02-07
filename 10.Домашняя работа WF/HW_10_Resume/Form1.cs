using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_10_Resume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.HotPink;
            label2.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.HotPink;
            button1.ForeColor = Color.White;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.HotPink;
            button2.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.HotPink;
            button3.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(resum3+ "\nКолчество символов в трех MessageBox = "+(resum.Length+resum2.Length+
                resum3.Length)+"\nСреднее количество символов на странице = "+
                ((resum.Length + resum2.Length + resum3.Length)/3));
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.HotPink;
            button4.ForeColor = Color.White;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.SkyBlue;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gainsboro;
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.SkyBlue;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Gainsboro;
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.SkyBlue;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Gainsboro;
        }
        string resum, resum2,resum3 = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null) {resum=textBox1.Text; }
            else { MessageBox.Show("Заполните первый MessageBox!!!"); }
            textBox1.Hide();
            button1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(resum);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null) { resum3 = textBox3.Text; }
            else { MessageBox.Show("Заполните второй MessageBox!!!"); }
            textBox3.Hide();
            button6.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null) { resum2 = textBox2.Text; }
            else { MessageBox.Show("Заполните второй MessageBox!!!"); }
            textBox2.Hide();
            button5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(resum2);
        }
    }
}
