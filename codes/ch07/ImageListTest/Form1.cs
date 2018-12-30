using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageListTest
{
    public partial class Form1 : Form
    {
        String[] imageList1 = new string[]
        {
            @"c:\image\1.jpg",
            @"c:\image\2.jpg",
            @"c:\image\3.jpg",
            @"c:\image\4.jpg"

        };

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
            pictureBox1.ImageLocation = imageList1[0];
        }

        private int curIndex = 0;
        private void button1_Click(object sender, System.EventArgs e)
        {   
            curIndex++;
            if (curIndex == imageList1.Length) curIndex = 0;
            pictureBox1.ImageLocation = imageList1[curIndex];
        }
        
    }
}
