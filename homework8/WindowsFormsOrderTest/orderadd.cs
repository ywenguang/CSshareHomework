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
    public partial class orderadd : Form
    {

        public Order order;
        public OrderService orderService;
        public Goods goods;
        public Customer customer;
        public OrderDetail orderDetail;

        public int orderId { get; set; }
        public string goodsName { get; set; }
        public uint goodsId { get; set; }
        public int price { get; set; }
        public uint clientId { get; set; }
        public string clientName { get; set; }
        public uint quantity { get; set; }
        
        public orderadd(Order order,Customer customer,Goods goods, OrderDetail orderDetail)
        {
            InitializeComponent();
            this.order = order;
            this.customer = customer;
            this.goods = goods;
            this.orderDetail = orderDetail;

            textBox1.DataBindings.Add("text", this, "orderId");
            textBox4.DataBindings.Add("text", this, "goodsId");
            textBox2.DataBindings.Add("text", this, "goodsName");
            textBox3.DataBindings.Add("text", this, "price");
            textBox6.DataBindings.Add("text", this, "clientName");
            textBox5.DataBindings.Add("text", this, "clientId");
            textBox7.DataBindings.Add("text", this, "quantity");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.order.Id = orderId;
            this.goods.Name = goodsName;
            this.goods.Id = goodsId;
            this.customer.Id = clientId;
            this.customer.Name = clientName;
            this.goods.Price = price;
            this.orderDetail.Quantity = quantity;

            Order order = new Order(this.order.Id,this.customer);
            OrderDetail detail = new OrderDetail(this.goods,this.orderDetail.Quantity);
            OrderService os = new OrderService();
            order.AddDetails(detail);
            os.AddOrder(order);
            this.Dispose();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void orderadd_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
