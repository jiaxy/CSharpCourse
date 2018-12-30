using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (this.progressBar1.Value < this.progressBar1.Maximum - 10){
                this.progressBar1.Value += 10;
            }else{
                this.progressBar1.Value = this.progressBar1.Minimum;
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
