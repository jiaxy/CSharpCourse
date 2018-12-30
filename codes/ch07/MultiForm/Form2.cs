using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form2 : Form
    {
        private string greeting = "";
        public string Greeting
        {
            get => greeting;
            set
            {
                greeting = value;
                this.Text = greeting;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String greeting):this()
        {
            this.Greeting = greeting;
        }
        
    }
}
