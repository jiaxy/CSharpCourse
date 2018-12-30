using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ImageListTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void PrepareImageList()
        {
            imageList1 = new ImageList();
            imageList1.ImageSize = new Size(100, 100);
            imageList1.Images.Add(
                Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\八仙花.jpg"));
            imageList1.Images.Add(
                Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\灯塔.jpg"));
            imageList1.Images.Add(
                Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\沙漠.jpg"));
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            PrepareImageList();
        }

        private int curIndex = 0;
        private void button1_Click(object sender, System.EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[curIndex];
            curIndex++;
            if (curIndex == imageList1.Images.Count) curIndex = 0;
        }
    }
}
