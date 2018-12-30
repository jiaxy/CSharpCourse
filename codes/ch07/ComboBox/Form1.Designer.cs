namespace ComboBox
{
    partial class Form1
    {
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
                                                           "Windows",
                                                           "OS/2",
                                                           "Unix",
                                                           "Linux",
                                                           "Macintosh"});
            this.comboBox1.Location = new System.Drawing.Point(24, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "comboBox1";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox2.Items.AddRange(new object[] {
                                                           "Windows",
                                                           "OS/2",
                                                           "Unix",
                                                           "Linux",
                                                           "Macintosh"});
            this.comboBox2.Location = new System.Drawing.Point(160, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 150);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "comboBox2";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Items.AddRange(new object[] {
                                                           "Windows",
                                                           "OS/2",
                                                           "Unix",
                                                           "Linux",
                                                           "Macintosh"});
            this.comboBox3.Location = new System.Drawing.Point(288, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(424, 221);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.comboBox3,
                                                                          this.comboBox2,
                                                                          this.comboBox1});
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

