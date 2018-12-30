using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<MovingShape> shapes = new List<MovingShape>();
        private List<Thread> threads = new List<Thread>();

        void AddMovingObject()
        {
            MovingShape obj = new MovingShape(this.pictureBox1);
            Thread thread = new Thread(obj.Run);
            thread.IsBackground = true;
            thread.Start();
            threads.Add(thread);
            shapes.Add(obj);
        }
        

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Show();
            AddMovingObject();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AddMovingObject();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            foreach(Thread thread in threads)
            {
                thread.Suspend();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Thread thread in threads)
            {
                if (thread.ThreadState.HasFlag
                    (ThreadState.Suspended))
                {
                    thread.Resume();
                }
                
            }
        }
    }

    public class MovingShape
    {
        bool bContinue = false;
        private int size = 60;
        private int speed = 10;
        private Color color;
        private Brush brush;
        private Pen pen;
        private int type;
        private int x, y, w, h, dx, dy;
        protected Control app;
        Random rnd = new Random();

        public MovingShape(Control app)
        {
            this.app = app;
            x = rnd.Next(app.Width);
            y = rnd.Next(app.Height);
            w = rnd.Next(10,size);
            h = rnd.Next(10,size);
            dx = rnd.Next(5,speed);
            dy = rnd.Next(5,speed);
            color = Color.FromArgb(
                rnd.Next(128, 256),
                rnd.Next(128, 256),
                rnd.Next(128, 256));
            brush = new SolidBrush(color);
            pen = new Pen(new SolidBrush(Color.Black), 1);
            type = rnd.Next(3);
            bContinue = true;
        }

        public void Run()
        {
            while (bContinue)
            {
                x += dx;
                y += dy;
                if (x < 0 || x + w > app.Width) dx = -dx;
                if (y < 0 || y + h > app.Height) dy = -dy;
                Graphics g = app.CreateGraphics();

                switch (type)
                {
                    case 0:
                        g.FillRectangle(brush, x, y, w, h);
                        g.DrawRectangle(pen, x, y, w, h);
                        break;
                    case 1:
                        g.FillEllipse(brush, x, y, w, h);
                        g.DrawEllipse(pen, x, y, w, h);
                        break;
                    case 2:
                        g.FillPie(brush, x, y, w, h, 0.1F, 0.9F);
                        g.DrawArc(pen, x, y, w, h, 0.1F, 0.9F);
                        break;
                }
                Thread.Sleep(130);
            }
        }

        public void Stop()
        {
            bContinue = false;
        }
    }
}
