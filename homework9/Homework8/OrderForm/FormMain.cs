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
  public partial class FormMain : Form {
    OrderService orderService;
    BindingSource fieldsBS = new BindingSource();
    public String Keyword { get; set; }

    public FormMain() {
      InitializeComponent();
      init();
    }

    public void init() {
      Customer customer1 = new Customer(1, "liuwang");
      Customer customer2 = new Customer(2, "jams");

      Goods apple = new Goods(3, "apple", 5.59f);
      Goods egg = new Goods(2, "egg", 4.99f);
      Goods milk = new Goods(1, "milk", 69.9f);

      OrderDetail orderDetails1 = new OrderDetail(apple, 8);
      OrderDetail orderDetails2 = new OrderDetail(egg, 2);
      OrderDetail orderDetails3 = new OrderDetail(milk, 1);

      Order order1 = new Order(1, customer1);
      Order order2 = new Order(2, customer2);
      Order order3 = new Order(3, customer2);

      order1.AddDetails(orderDetails1);
      order1.AddDetails(orderDetails2);
      order1.AddDetails(orderDetails3);
      order2.AddDetails(orderDetails2);
      order2.AddDetails(orderDetails3);
      order3.AddDetails(orderDetails3);

      orderService = new OrderService();
      orderService.AddOrder(order1);
      orderService.AddOrder(order2);
      orderService.AddOrder(order3);
      orderBindingSource.DataSource = orderService.QueryAll();

      txtValue.DataBindings.Add("Text", this, "Keyword");
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      FormEdit form2 = new FormEdit(new Order());
      form2.ShowDialog();
      if (form2.Result != null) {
        orderService.AddOrder(form2.Result);
        QueryAll();
      }

    }

    private void QueryAll() {
      orderBindingSource.DataSource = orderService.QueryAll();
      orderBindingSource.ResetBindings(false);
    }

    private void btnModify_Click(object sender, EventArgs e) {
      FormEdit form2 = 
        new FormEdit((Order)orderBindingSource.Current);
      form2.ShowDialog();
      QueryAll();
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      Order o = (Order)orderBindingSource.Current;
      if (o != null) {
        orderService.RemoveOrder(o.Id);
        QueryAll();
      }

    }

    private void btnExport_Click(object sender, EventArgs e) {
      DialogResult result = saveFileDialog1.ShowDialog();
      if (result.Equals(DialogResult.OK)) {
        String fileName = saveFileDialog1.FileName;
        orderService.Export(fileName);
      }

    }

    private void btnImport_Click(object sender, EventArgs e) {
      DialogResult result = openFileDialog1.ShowDialog();
      if (result.Equals(DialogResult.OK)) {
        String fileName = openFileDialog1.FileName;
        orderService.Import(fileName);
        QueryAll();
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      switch (cbField.SelectedIndex) {
        case 0:
          orderBindingSource.DataSource =
              orderService.QueryAll();
          break;
        case 1:
          int.TryParse(Keyword, out int id);
          orderBindingSource.DataSource = orderService.GetById(id);
          break;
        case 2:
          orderBindingSource.DataSource =
                  orderService.QueryByCustomerName(Keyword);
          break;
        case 3:
          orderBindingSource.DataSource =
                  orderService.QueryByGoodsName(Keyword);
          break;
        case 4:
          float.TryParse(Keyword,  out float amout);
          orderBindingSource.DataSource =
                 orderService.QueryByTotalAmount(amout);
          break;
      }

    }

    private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) {

    }
  }
}
