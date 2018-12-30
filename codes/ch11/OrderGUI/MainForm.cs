using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFDemo;

namespace OrderGUI {
  public partial class MainForm : Form {
    OrderService orderService = new OrderService();
    public MainForm() {
      InitializeComponent();
      orderBindingSource.DataSource = orderService.GetAllOrders();
    }

    private void button1_Click(object sender, EventArgs e) {
      queryOrder();
    }


    private void button2_Click(object sender, EventArgs e) {
      EditForm editForm = new EditForm(null);
      editForm.ShowDialog();
      queryOrder();
    }

    private void button3_Click(object sender, EventArgs e) {
      if (orderBindingSource.Current != null) {
        EditForm editForm = new EditForm((Order)orderBindingSource.Current);
        editForm.ShowDialog();
        queryOrder();
      }
      else {
        MessageBox.Show("No Order is selected!");
      }
    }
    private void button4_Click(object sender, EventArgs e) {
      if (orderBindingSource.Current != null) {
        Order order=(Order)orderBindingSource.Current;
        orderService.Delete(order.Id);
        queryOrder();
      }
      else {
        MessageBox.Show("No Order is selected!");
      }
    }

    private void queryOrder() {
      switch (comboBox1.SelectedIndex) {
        
        case 1:
          orderBindingSource.DataSource =
            orderService.GetOrder(textBox1.Text);
          break;
        case 2:
          orderBindingSource.DataSource =
            orderService.QueryByCustormer(textBox1.Text);
          break;
        case 3:
          orderBindingSource.DataSource =
            orderService.QueryByGoods(textBox1.Text);
          break;
        default:
          orderBindingSource.DataSource = orderService.GetAllOrders();
          break;
      }
      orderBindingSource.ResetBindings(false);
      itemsBindingSource.ResetBindings(false);
    }

   
  }
}
