using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 101;

            int []number = new int[N];
            number[0] = number[1] = 1;
            number[2] = 0;

            int k = 2, j = 0;

            while (j < N)
            {
                for (int i = 1; i < N; i++) //将不是素数的数筛出
                {
                    if (i % k == 0 && i != k)
                        number[i] = 1;//不符合要求的全部置为1
                }

                for (int i = 1; i < N; i++) //将筛选后的第一个数当做新的筛子
                {
                    if (i > k && number[i] == 0)
                    {
                        k = i;
                        break;
                    }
                }
                j++;
            }

            for (int i = 1; i < N; i++)
                if (number[i] == 0)
                    Console.WriteLine(+i);
        }     
    }
}

