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
    public partial class ordermodify : Form
    {
        public int orderid { get; set; }
        public string goodsname { get; set; }
        public string clientname { get; set; }
        public Order order;
        public Customer customer;
        

        public ordermodify(Order order,Customer customer)
        {
            InitializeComponent();
            this.order = order;
            this.customer = customer;

            textBox2.DataBindings.Add("text", this, "orderId");
            textBox4.DataBindings.Add("text", this, "clientName");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ordermodify_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.order.Id = this.orderid;
            this.order.Customer.Name = this.clientname;
            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
