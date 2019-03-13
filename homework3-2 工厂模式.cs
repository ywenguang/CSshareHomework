using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*此处将简单工厂模式升级为工厂模式， 在简单工厂模式中，将所有对象的创建都
             * 集中在一个类中，增加了if-else的嵌套，而在工厂模式中，将工厂Factory设置
             * 为抽象类，在Factory的子类中实现具体的某个对象的创建，从而减少if-else的
             * 嵌套，另外，此时如果增加其他的日志文件类型，只需要增加一个新的Factory的
             * 子类即可，而不用更改其他的类
             */      
            ILoggerFactory factory1,factory2;
            ILogger logger1,logger2;
            factory1 = new FileLoggerFactory();
            logger1 = factory1.createLogger();
            logger1.writeLogger();
            
            factory2 = new CountLoggerFactory();
            logger2 = factory2.createLogger();
            logger2.writeLogger();


        }
    }

    public interface ILogger
    {
        void writeLogger();
    }

    class DatebaseLogger:ILogger
    {
        public void writeLogger()
        {
            Console.WriteLine("数据库日志记录！");

        }
    }

    class FileLogger : ILogger
    {
        public void writeLogger()
        {
            Console.WriteLine("文件日志记录！");
        }
    }

    public interface ILoggerFactory
    {
        ILogger createLogger();

    }

    class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger createLogger()
        {
            ILogger logger = new DatebaseLogger();
            return logger;

        }
    }

    class FileLoggerFactory : ILoggerFactory
    {
        public ILogger createLogger()
        {
            ILogger logger = new FileLogger();
            return logger;

        }
    }


    //假设在此处新加了一个数字日志，此时只需要进行增加其子类就行，而不需要更改其他类
    class CountLogger : ILogger
    {
        public void writeLogger()
        {
            Console.WriteLine("最后增加的数字日志！");
        }
    }

    class CountLoggerFactory :ILoggerFactory
    {
        public ILogger createLogger()
        {
            ILogger logger = new CountLogger();
            return logger;
        }
    }



}
