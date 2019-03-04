using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 5;
            int max, min, sum = 0, agv;

            int[] a = new int[N];

            Console.WriteLine("请输入"+N+"个整数:");
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            max = a[0];
            min = a[0];

            for (int i = 0; i < N; i++)
            {
                if (a[i] > max)
                    max = a[i];
                if (a[i] < min)
                    min = a[i];
                sum = sum + a[i];

            }
            agv = sum / N;

            Console.WriteLine("最大值：" + max + "\n" + "最小值：" + min);
            Console.WriteLine("平均值：" + agv + "\n" + "数组和：" + sum);

        }
    }
}
