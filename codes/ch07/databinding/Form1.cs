using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databinding
{
    public partial class Form1 : Form
    {
        public List<Student> students = new List<Student>();
        public string KeyWord { get; set; }

        public Form1(){
            InitializeComponent();
            students.Add(new Student("zhang", 1, 20));
            students.Add(new Student("li", 2, 19));
            studentBindingSource.DataSource = students;
            //绑定查询条件
            queryInput.DataBindings.Add("Text", this, "KeyWord");
        }

        private void button1_Click(object sender, EventArgs e){
            if (KeyWord == null||KeyWord==""){
                studentBindingSource.DataSource =students;
            }else{
                studentBindingSource.DataSource =
                    students.Where(s => s.Name == KeyWord);
            }
           
        }
    }
}
