using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatePlot
{
    delegate double Fun(double x);

    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        void PlotFun(Fun fun, Graphics g, Pen pen) {
            for (double x = 0; x < 100; x += 0.1){
                double y = fun(x);
                Point point = new Point((int)(x * 20), (int)(200 - y * 30));
                g.DrawLine(pen, point, new Point(point.X + 2, point.Y + 2));
                Console.WriteLine(" " + x + " " + y);
            }
        }

        double Square(double x) {
            return Math.Sqrt(Math.Sqrt(x));
        }
        static double XPlus(double x) {
            return Math.Sin(x) + Math.Cos(x * 5) / 5;
        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics g= e.Graphics;
            Pen pen = Pens.Blue;
            Fun[] funs = {new Fun( this.Square ),
                          new Fun( Form1.XPlus ),
                          new Fun( Math.Cos ),
                          new Fun( Math.Sqrt )
                          };
            foreach (Fun fun in funs){
                PlotFun(fun, g, pen);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
    }
}
