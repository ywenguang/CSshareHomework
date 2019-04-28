using ordertest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm {
  public partial class FormEdit : Form {
    public Order Result { get => (Order)orderBindingSource.Current; }

    public FormEdit() {
      InitializeComponent();

      customerBindingSource.Add(new Customer(1, "liuwang"));
      customerBindingSource.Add(new Customer(2, "jams"));
      goodsBindingSource.Add(new Goods(3, "apple", 5.59f));
      goodsBindingSource.Add(new Goods(2, "egg", 4.99f));
      goodsBindingSource.Add(new Goods(1, "milk", 69.9f));
    }

    public FormEdit(Order order) : this() {
      orderBindingSource.DataSource = order;
    }

    private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {

    }

    private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
      ((OrderDetail)detailsBindingSource.Current).Goods = (Goods)comboBox2.SelectedItem;
      detailsBindingSource.ResetBindings(false);
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      ((Order)orderBindingSource.Current).Customer = (Customer)comboBox1.SelectedItem;
      detailsBindingSource.ResetBindings(false);
    }

    private void FormEdit_Load(object sender, EventArgs e) {
      comboBox1.SelectedItem =
          ((Order)orderBindingSource.Current).Customer;
      if (detailsBindingSource.Current != null) {
        comboBox2.SelectedItem =
                 ((OrderDetail)detailsBindingSource.Current).Goods;
      }else {
        groupBox3.Enabled = false;
      }
     
    }

    private void btnAddDetail_Click(object sender, EventArgs e) {
      OrderDetail detail = new OrderDetail();
      ((Order)orderBindingSource.Current).AddDetails(detail);
      detailsBindingSource.MoveLast();
      comboBox2.SelectedItem = null;
      orderBindingSource.ResetBindings(false);
    }

    private void textBox2_TextChanged(object sender, EventArgs e) {
      orderBindingSource.ResetBindings(false);
    }

    private void detailsBindingSource_AddingNew(object sender, AddingNewEventArgs e) {
      groupBox3.Enabled = true;
    }

    private void button1_Click_1(object sender, EventArgs e) {
      this.Close();
    }

    private void detailsBindingSource_CurrentChanged(object sender, EventArgs e) {
      if (detailsBindingSource.Current != null) {
        comboBox2.SelectedItem =
                 ((OrderDetail)detailsBindingSource.Current).Goods;
      }
      else {
        groupBox3.Enabled = false;
      }
    }
  }
}
