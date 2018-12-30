using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FontMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                richTextBox1.SelectionFont= fontDialog1.Font;
            }
        }

        private void ColorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK){
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void NewFileMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                statusLabel1.Text = openFileDialog1.FileName;
            }
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                statusLabel1.Text = saveFileDialog1.FileName;
            }
        }

     

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewFileMenuItem_Click(sender, e);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileMenuItem_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileMenuItem_Click(sender, e);
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("文本编辑器V1.0","关于");
        }
    }
}
