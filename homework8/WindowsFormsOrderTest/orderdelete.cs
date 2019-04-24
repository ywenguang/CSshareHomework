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
    public partial class orderdelete : Form
    {
        public OrderService os;
        public Order order;
        public int orderId { get; set; }

        public orderdelete(OrderService os,Order order)
        {
            InitializeComponent();
            this.order = order;
            this.os = os;
            textBox1.DataBindings.Add("text", this, "orderId");
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.order=this.os.GetById(this.orderId);
            this.os.RemoveOrder(this.order.Id);
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void orderdelete_Load(object sender, EventArgs e)
        {

        }
    }
}
