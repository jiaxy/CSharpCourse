namespace OrderGUI {
  partial class MainForm {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.dataGridView2 = new System.Windows.Forms.DataGridView();
      this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.button4);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.comboBox1);
      this.panel1.Controls.Add(this.textBox1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(5, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(790, 65);
      this.panel1.TabIndex = 0;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(656, 20);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 23);
      this.button4.TabIndex = 5;
      this.button4.Text = "Delete";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(563, 21);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 4;
      this.button3.Text = "Edit";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(473, 21);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 3;
      this.button2.Text = "Add";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(380, 20);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Query";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "所有订单",
            "订单号等于",
            "客户名等于",
            "货物包含"});
      this.comboBox1.Location = new System.Drawing.Point(33, 22);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 20);
      this.comboBox1.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(176, 21);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(185, 21);
      this.textBox1.TabIndex = 0;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(5, 70);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
      this.splitContainer1.Size = new System.Drawing.Size(790, 375);
      this.splitContainer1.SplitterDistance = 263;
      this.splitContainer1.TabIndex = 1;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.orderBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(263, 375);
      this.dataGridView1.TabIndex = 0;
      // 
      // dataGridView2
      // 
      this.dataGridView2.AutoGenerateColumns = false;
      this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.productDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
      this.dataGridView2.DataSource = this.itemsBindingSource;
      this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView2.Location = new System.Drawing.Point(0, 0);
      this.dataGridView2.Name = "dataGridView2";
      this.dataGridView2.RowTemplate.Height = 23;
      this.dataGridView2.Size = new System.Drawing.Size(523, 375);
      this.dataGridView2.TabIndex = 0;
      // 
      // itemsBindingSource
      // 
      this.itemsBindingSource.DataMember = "Items";
      this.itemsBindingSource.DataSource = this.orderBindingSource;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // customerDataGridViewTextBoxColumn
      // 
      this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
      this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
      this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
      // 
      // createTimeDataGridViewTextBoxColumn
      // 
      this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
      this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
      this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(EFDemo.Order);
      // 
      // idDataGridViewTextBoxColumn1
      // 
      this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
      // 
      // productDataGridViewTextBoxColumn
      // 
      this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
      this.productDataGridViewTextBoxColumn.HeaderText = "Product";
      this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
      // 
      // unitPriceDataGridViewTextBoxColumn
      // 
      this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
      this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
      this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
      // 
      // quantityDataGridViewTextBoxColumn
      // 
      this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
      this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
      this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.panel1);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource orderBindingSource;
    private System.Windows.Forms.DataGridView dataGridView2;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource itemsBindingSource;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
  }
}

