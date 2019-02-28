using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please input a number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("you have entered :" + n+"\n");
     
            Console.Write("please input another number:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("you have entered :" + m);
          
            Console.WriteLine("sum:"+(m*n));
            Console.ReadLine();
        }
    }
}
