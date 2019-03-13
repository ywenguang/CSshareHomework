using SampleFactoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFactoryModel
{
    class Program
    {
        static void Main(string[] args)
        {
            IChart chart;
            chart = chartFactory.getChart("histogram"); //通过静态工厂方法创建产品			
            chart.Display();
        }
    }

    public interface IChart//抽象图表接口：抽象产品类
    { 
        void Display();
    }

    class HistogarmChart : IChart//具体产品类
    {
        public void Display()
        {
            Console.WriteLine("显示柱状图！");
        }

        public HistogarmChart()
        {
            Console.WriteLine("创建柱状图！");
            
        }
       
    }

    class pieChart : IChart
    {
        public void Display()
        {
            Console.WriteLine("显示饼状图！");
        }

        public pieChart()
        {
            Console.WriteLine("创建饼状图！");
        }

    }

    class LineChart : IChart
    {
        public void Display()
        {
            Console.WriteLine("显示折线图！");
        }
        public LineChart()
        {
            Console.WriteLine("创建折线图！");
        }
    }

    class chartFactory
        //图表工厂类，采用静态工厂方法
    {
        public static IChart getChart(string type)
        {
            IChart chart = null;
            if (type == ("histogram"))
            {
                chart = new HistogarmChart();
                Console.WriteLine("初始化设置柱状图！");
            }
            else if (type == ("pie"))
            {
                chart = new pieChart();
                Console.WriteLine("初始化设置饼状图！");
            }
            else if (type == ("line"))
            {
                chart = new LineChart();
                Console.WriteLine("初始化设置折线图！");
            }
            return chart;
        }
    }




}
