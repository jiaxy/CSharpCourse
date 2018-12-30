namespace OrderGUI {
  partial class EditForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dateTimePicker1);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.textBox2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.textBox1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(10, 10);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(591, 130);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Order Info";
      // 
      // textBox1
      // 
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
      this.textBox1.Location = new System.Drawing.Point(140, 20);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(200, 21);
      this.textBox1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(53, 25);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "Order Id";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(53, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "Customer";
      // 
      // textBox2
      // 
      this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Customer", true));
      this.textBox2.Location = new System.Drawing.Point(140, 58);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(200, 21);
      this.textBox2.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(53, 102);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 12);
      this.label3.TabIndex = 5;
      this.label3.Text = "Create Time";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "CreateTime", true));
      this.dateTimePicker1.Location = new System.Drawing.Point(140, 99);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
      this.dateTimePicker1.TabIndex = 6;
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.itemsBindingSource;
      this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataGridView1.Location = new System.Drawing.Point(10, 140);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 23;
      this.dataGridView1.Size = new System.Drawing.Size(591, 268);
      this.dataGridView1.TabIndex = 1;
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(EFDemo.Order);
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
      // panel1
      // 
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(10, 408);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(591, 32);
      this.panel1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(237, 6);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // EditForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(611, 450);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.Name = "EditForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "EditForm";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource orderBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource itemsBindingSource;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
  }
}