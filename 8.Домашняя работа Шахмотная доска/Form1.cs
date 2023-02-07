using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.Домашняя_работа_Шахмотная_доска
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //элемент класса массив панелей для отслеживания плиток шахматной доски
        private Panel[,] _chessBoardPanels;

        //private ContextMenuStrip contextMenuStrip2=null; private ContextMenuStrip contextMenuStrip3=null;
        //private ContextMenuStrip contextMenuStrip4; private ContextMenuStrip contextMenuStrip5;
        //private ContextMenuStrip contextMenuStrip6; private ContextMenuStrip contextMenuStrip7;
        //private ContextMenuStrip contextMenuStrip8; private ContextMenuStrip contextMenuStrip9;
        //private ContextMenuStrip contextMenuStrip10; private ContextMenuStrip contextMenuStrip11;
        //private ContextMenuStrip contextMenuStrip12;

        private void Form1_Load(object sender, EventArgs e)
        {
            const int tileSize = 40;
            const int gridSize = 12;
            var clr1 = Color.CadetBlue;
            var clr2 = Color.BurlyWood;
            //contextMenuStrip1.Show(Cursor.Position);
            //pictureBox1.ContextMenu = ContextMenu;

            //изображение белых фигур появляетяся в pictureBox
            pictureBox1.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\белая пешка.png");
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            contextMenuStrip1.Text = "белая пешка";
            pictureBox2.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\белый конь.png");
            pictureBox2.ContextMenuStrip = contextMenuStrip2;
            contextMenuStrip2.Text = "белый конь";
            pictureBox3.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\белая башня.png");
            pictureBox3.ContextMenuStrip = contextMenuStrip3;
            contextMenuStrip3.Text = "белая башня";
            pictureBox4.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\белый офицер.png");
            pictureBox4.ContextMenuStrip = contextMenuStrip4;
            contextMenuStrip4.Text = "белый офицер";
            pictureBox5.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\белая королева.png");
            pictureBox5.ContextMenuStrip = contextMenuStrip5;
            contextMenuStrip5.Text = "белая королева";
            pictureBox6.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\белый король.png");
            pictureBox6.ContextMenuStrip = contextMenuStrip6;
            contextMenuStrip6.Text = "белый король";
            //изображение чёпных фигур появляетяся в pictureBox
            pictureBox7.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\чёрная пешка.png");
            pictureBox7.ContextMenuStrip = contextMenuStrip7;
            contextMenuStrip7.Text = "чёрная пешка";
            pictureBox8.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\чёрный конь.png");
            pictureBox8.ContextMenuStrip = contextMenuStrip8;
            contextMenuStrip8.Text = "чёрный конь";
            pictureBox9.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\чёрная башня.png");
            pictureBox9.ContextMenuStrip = contextMenuStrip9;
            contextMenuStrip9.Text = "чёрная башня";
            pictureBox10.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\чёрный офицер.png");
            pictureBox10.ContextMenuStrip = contextMenuStrip10;
            contextMenuStrip10.Text = "чёрный офицер";
            pictureBox11.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\чёрная королева.png");
            pictureBox11.ContextMenuStrip = contextMenuStrip11;
            contextMenuStrip11.Text = "чёрная королева";
            pictureBox12.Image = Image.FromFile("C:\\Users\\User\\Desktop\\домашняя работа\\Домашняя работа по FORM\\8.Домашняя работа Шахмотная доска\\чёрный король.png");
            pictureBox12.ContextMenuStrip = contextMenuStrip12;
            contextMenuStrip12.Text = "чёрный король";
            //инициализировать "шахматную доску"
            _chessBoardPanels = new Panel[gridSize, gridSize];

            // двойной цикл for для обработки всех строк и столбцов
            for (var n = 0; n < gridSize; n++)
            {
                for (var m = 0; m < gridSize; m++)
                {
                    // создайте новую панель управления, которая будет представлять собой однуплитку
                    // шахматная доска
                    var newPanel = new Panel
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point(tileSize * n, tileSize * m)
                    };

                    // добавить в элементы управления формы, чтобы они отображались
                    Controls.Add(newPanel);

                    // добавить в наш 2d-массив панелей для будущего использования
                    _chessBoardPanels[n, m] = newPanel;

                    // раскрасьте фон
                    if (n % 2 == 0)
                        newPanel.BackColor = m % 2 != 0 ? clr1 : clr2;
                    else
                        newPanel.BackColor = m % 2 != 0 ? clr2 : clr1;
                }
            }
        }
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Left)

            {
                ContextMenuStrip.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Show(Cursor.Position);
            //pictureBox1.ContextMenuStrip = contextMenuStrip1;

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            //contextMenuStrip2.Text = "белый конь";
        }
    }
}
