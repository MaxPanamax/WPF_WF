using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private string fileName = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFilesToTreeView(@"txt files (*.txt)|*.txt|All files (*.*)|*.*", treeView1);
            Load_Data();
        }
        private void Load_Data()
        {
            //TextBoxDescription.Clear();
            listView1.Items.Clear();
            OpenFileDialog open = new OpenFileDialog
            {
                //создали экземпляр. Установим фильтр для файлов
                Filter = "All files (*.*)|*.*",
                FilterIndex = 1, //По умолчанию фильтруются текстовые файлы
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) //По умолчанию путь к рабочему столу
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                listView1.Text = reader.ReadToEnd();//Считываем файл до конца
                if (listView1.Text.Length > 0)
                    fileName = open.FileName;
                reader.Close(); //Закрываем файл
            }
        }
        //public void OpenFilesToTreeView (string NameFiles, TreeView treeview)
        //{
        //    string lineFile;
        //    string[] tmplineFile;
        //    FileStream file1 = new FileStream(NameFiles, FileMode.Open);
        //    using (StreamReader readerFiles = new StreamReader(file1))
        //    {
        //        while ((lineFile = readerFiles.ReadLine()) != null)
        //        {
        //            tmplineFile = new[] { lineFile };
        //            BuildTree(treeview.Nodes, tmplineFile);
        //        }
        //    }
        //}


        private void BuildTree(TreeNodeCollection nodes, string[] list)
        {
            foreach (var path in list)
            {
                var childs = nodes;
                var pathAndFile = path.Split(';')[0];
                var parts = pathAndFile.Split('\\');
                for (int i = 0; i < parts.Length - 1; i++)
                {
                    childs = FindOrCreateNode(childs, parts[i]).Nodes;
                }
            }
        }

        private TreeNode FindOrCreateNode(TreeNodeCollection coll, string name)
        {
            var found = coll.Find(name.ToLower(), false);
            if (found.Length > 0) return found[0];
            return coll.Add(name.ToLower(), name);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listView1.Items.Clear();
            string lineFile;
            string[] tmplineFile;
            string tmpPath;
            string[] tmpFiles;
            string FullPathTree = e.Node.FullPath.ToString() + "\\";
            //string tmpFullPath = e.Node.FullPath.ToString() + "\\";
            FileStream file1 = new FileStream(@"All files (*.*)|*.*", FileMode.Open);
            using (StreamReader readerFiles = new StreamReader(file1))
            {

                while ((lineFile = readerFiles.ReadLine()) != null)
                {
                    tmplineFile = new[] { lineFile };
                    foreach (string path in tmplineFile)
                    {
                        tmpPath = path.Split(';')[0];
                        if (FullPathTree.TrimEnd() == tmpPath.ToString().TrimEnd())
                        {
                            tmpFiles =  path.Split(';');
                            string[] col = { tmpFiles[1] , tmpFiles[2]};
                            var listview = new ListViewItem(col);
                            listView1.Items.Add(listview);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
