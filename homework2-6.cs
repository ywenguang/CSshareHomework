using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("请输入一个 int 类型的整数：");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num;)
            {
                if (num % i == 0)
                {
                    Console.Write( +i + "  ");
                    num /= i;
                }
                else i++;
            }
             
        }
    }
}
