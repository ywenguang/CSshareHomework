using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ordertest;




namespace WindowsFormsOrderTest
{

    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
            Customer customer1 = new Customer(1, "Customer1");
            Customer customer2 = new Customer(2, "Customer2");

            Goods milk = new Goods(1, "Milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetail(apple, 8));
            order1.AddDetails(new OrderDetail(eggs, 10));
            // order1.AddDetails(new OrderDetail(eggs, 8));
            order1.AddDetails(new OrderDetail(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetail(eggs, 10));
            order2.AddDetails(new OrderDetail(milk, 10));

            Order order3 = new Order(3, customer2);
            order3.AddDetails(new OrderDetail(milk, 100));

            OrderService orderService = new OrderService();
            List<Order> orders = orderService.QueryAll();

            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            
            orderDetailBindingSource.DataSource = orders;
            textBox1.DataBindings.Add("text", this,"Keyword");
        }

        private void AddNodes()
        {
            TreeNode tn = new TreeNode("Orders", 0, 0);
            treeView1.Nodes.Add(tn);
            TreeNode tn1 = new TreeNode("order", 1, 1);
            tn.Nodes.Add(tn1);
            
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;

        }

        private void treeView1_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 4;
            e.Node.SelectedImageIndex = 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.QueryAll();

            if (radioButton1.Checked)
            {
                if (textBox1.Text==null)
                    orderDetailBindingSource.DataSource = orders;
                else
                {
                    orderDetailBindingSource.DataSource = orders.Where(s => s.Id == int.Parse(textBox1.Text));
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                OrderService os = new OrderService();
                Order order = os.GetById(int.Parse(textBox1.Text));
                new ordermodify(order, order.Customer).Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddNodes();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Order order = new Order();
                Customer customer = new Customer();
                Goods goods = new Goods();
                OrderDetail orderDetail = new OrderDetail();

                new orderadd(order,customer,goods,orderDetail).Show();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderService os = new OrderService();
            List<Order> orders = os.QueryAll();
            orderDetailBindingSource.DataSource = orders;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                OrderService os = new OrderService();
                Order order = os.GetById(int.Parse(textBox1.Text));
                new orderdelete(os,order).Show();

            }
        }
    }
}
