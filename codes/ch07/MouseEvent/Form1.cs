using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lblPosition.Text = $"({e.X},{e.Y})";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lblEvent.Text = "鼠标单击！";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            lblEvent.Text = "鼠标双击！";
        }
    }
}
