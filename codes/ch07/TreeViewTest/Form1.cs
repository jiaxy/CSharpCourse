using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewTest
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

       
  
        private void AddNodes()
        {
            // Create and add a root node
            TreeNode tn = new TreeNode("Root", 0, 0);
            treeView1.Nodes.Add(tn);
            // Add a child node
            TreeNode tn1 = new TreeNode("Child1", 1, 1);
            tn.Nodes.Add(tn1);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            AddNodes();
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode("Child", 1, 1);
            treeView1.SelectedNode.Nodes.Add(tn);
            treeView1.SelectedNode.ImageIndex = 0;
            treeView1.SelectedNode.SelectedImageIndex = 0;
            treeView1.SelectedNode.ExpandAll();
   
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;

        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 2;
            e.Node.SelectedImageIndex = 2;

        }
    }


}
