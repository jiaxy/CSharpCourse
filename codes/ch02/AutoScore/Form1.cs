using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AutoScore
{
	/// <summary>
	/// Form1 的摘要说明。
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblOp;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblEq;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnJudge;
		private System.Windows.Forms.ListBox lstDisp;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.lblA = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblEq = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnJudge = new System.Windows.Forms.Button();
            this.lstDisp = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.Location = new System.Drawing.Point(32, 41);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(43, 30);
            this.lblA.TabIndex = 0;
            // 
            // lblOp
            // 
            this.lblOp.Location = new System.Drawing.Point(96, 41);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(43, 30);
            this.lblOp.TabIndex = 0;
            // 
            // lblB
            // 
            this.lblB.Location = new System.Drawing.Point(160, 41);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(43, 30);
            this.lblB.TabIndex = 0;
            // 
            // lblEq
            // 
            this.lblEq.Location = new System.Drawing.Point(213, 41);
            this.lblEq.Name = "lblEq";
            this.lblEq.Size = new System.Drawing.Size(43, 30);
            this.lblEq.TabIndex = 0;
            this.lblEq.Text = "=";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(267, 41);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(133, 25);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.Text = "textBox1";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(75, 113);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "出题";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(213, 113);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(100, 30);
            this.btnJudge.TabIndex = 2;
            this.btnJudge.Text = "判分";
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // lstDisp
            // 
            this.lstDisp.ItemHeight = 15;
            this.lstDisp.Location = new System.Drawing.Point(32, 175);
            this.lstDisp.Name = "lstDisp";
            this.lstDisp.Size = new System.Drawing.Size(331, 154);
            this.lstDisp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.ClientSize = new System.Drawing.Size(473, 365);
            this.Controls.Add(this.lstDisp);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblEq);
            this.Controls.Add(this.btnJudge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		int a, b;
		string op;
		int result;

		private void btnNew_Click(object sender, System.EventArgs e)
		{
			Random rnd = new Random();
			a = rnd.Next( 9 ) + 1;
			b = rnd.Next( 9 ) + 1;
			int c = rnd.Next( 4 );
			switch( c )
			{
				case 0: op="+"; result=a+b; break;
				case 1: op="-"; result=a-b; break;
				case 2: op="*"; result=a*b; break;
				case 3: op="/"; result=a/b; break;
			}
			lblA.Text=(""+a);
			lblB.Text=(""+b);
			lblOp.Text=(""+op);
			txtAnswer.Text=("");

		}

		private void btnJudge_Click(object sender, System.EventArgs e)
		{
			// to do: code goes here.
			string str = txtAnswer.Text;
			double d = Double.Parse( str );
			string disp = "" + a + op + b+"="+ str +" ";
			if( d == result ) 
				disp += "☆";
			else 
				disp += "╳";
		
			lstDisp.Items.Add( disp );

		}
	}
}
