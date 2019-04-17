using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawtrees
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double k = 1;
        
        double th1 = 30 *Math.PI / 180;
        double th2 = 50 *Math.PI / 180;
        
        double per1 = 0.5;
        double per2 = 0.6;
        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if(n==0)
            {
                return;
            }

            double x1 = x0 + leng* k * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);
            
        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
      
        }

        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.CreateGraphics();
            drawCayleyTree(10, 200, 310, 100,  -Math.PI / 2);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            per1 = (double)this.hScrollBar1.Value / 100;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            th1 = (double)this.vScrollBar1.Value / 100;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            per2 = (double)this.hScrollBar1.Value / 100;
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            th2 = (double)this.vScrollBar1.Value / 100;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
