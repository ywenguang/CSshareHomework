using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using OrderManage.OrderManagement;


namespace OrderManage
{
    
    //using System.Collections;
    
    namespace OrderManagement
    {
        /*添加一个文件读写类FileAccess，至少包括2个方法，文件的读方法和文件写方法。
         * 读方法设计时，需要用到集合类，将读取到的所有订单添加到该集合，
         * 例如arraylist；写方法设计时，注意每次向文件写入一行,即每个订单占去一行。*/

        class FileAccessOperate
        {
            static string txtDictionary = @"e:\c#\OrderManage\";
            //写方法
            public void OrdWrite(List<Order> ordList)
            {
                string path = txtDictionary + "ord.txt";    //订单信息存储路径

                FileInfo fi = new FileInfo(path);

                //判断文件是否存在
                if (fi.Exists == false)
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    fs.Close();
                    fi = new FileInfo(path);
                }
                //判断文件是否为空，即是否是第一次序列化存储
                if (fi.Length > 0)
                {
                    //如果不为空，即已经进行过序列化存储，需将之前存的信息，反序列化读取，添加到要存储的对象集，覆盖存储
                    List<Order> OrdListRead = OrdRead();

                    foreach (Order ord in OrdListRead)
                    {
                        ordList.Add(ord);
                    }
                }

                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter(); //创建序列化对象 

                //序列化
                bf.Serialize(stream, ordList);
                stream.Close();
            }

            //删除订单
            public void DeleteOrd(int num)
            {
                List<Order> ordList = OrdRead();

                for (int i = 0; i < ordList.Count; i++)
                {
                    if (ordList[i].OrdNum == num)
                        ordList.Remove(ordList[i]);
                }

                string path = txtDictionary + "ord.txt";    //订单信息存储路径
                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter(); //创建序列化对象 

                bf.Serialize(stream, ordList);
                stream.Close();
            }

            //读方法
            public List<Order> OrdRead()
            {
                string path = txtDictionary + "ord.txt";    //订单信息存储路径

                FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter(); //创建序列化对象
                List<Order> ordList;

                ordList = bf.Deserialize(stream) as List<Order>;

                stream.Close();
                return ordList;
            }

        }
    }




    [Serializable]
    class Order
    {
        private int ordNum;  //订单编号

        public int OrdNum
        {
            get { return ordNum; }
            set { ordNum = value; }
        }

        private string ordName;  //订单名称

        public string OrdName
        {
            get { return ordName; }
            set { ordName = value; }
        }

        private string goodsAmount;     //货物数量

        public string GoodsAmount
        {
            get { return goodsAmount; }
            set { goodsAmount = value; }
        }

        private string goodsName;    //货物名称

        public string GoodsName
        {
            get { return goodsName; }
            set { goodsName = value; }
        }

        private string goodsNumber;    //货物编号

        public string GoodsNumber
        {
            get { return goodsNumber; }
            set { goodsNumber = value; }
        }

        //构造函数初始化
        public Order(int ordNum, string ordName, string goodsAmount, string goodsName, string goodsNumber)
        {
            this.ordNum = ordNum;
            this.ordName = ordName;
            this.goodsAmount = goodsAmount;
            this.goodsName = goodsName;
            this.goodsNumber = goodsNumber;
        }
    }

    class OrderManger
    {

        FileAccessOperate faOper = new FileAccessOperate();

        //添加订单信息方法
        public void AddOrder()
        {
            List<Order> ordList = new List<Order>();

            Console.Write("请输入要添加订单的订单数：");
            int totalAdd = 0; //每次输入的订单数
            int count = 0;  //记录一个输入的订单数
            //Order[] ordArr=new Order[100];  //记录订单的数组
            int ordNum; //订单属性，初始化
            string ordName, goodsAmount, goodsName, goodsNumber;

            //判断输入是否正确           
            try
            {
                totalAdd = int.Parse(Console.ReadLine());
                if (totalAdd < 1)
                    throw new Exception();
            }
            catch
            {
                Console.WriteLine("请输入一个正整数");
            }

            while (totalAdd > 0)
            {
                int countSort = count + 1;
                Console.Write("请输入第{0}个订单的订单编号：", countSort);
                ordNum = int.Parse(Console.ReadLine());

                Console.Write("请输入第{0}个订单的订单名称：", countSort);
                ordName = Console.ReadLine();

                Console.Write("请输入第{0}个订单的货物数量：", countSort);
                goodsAmount = Console.ReadLine();

                Console.Write("请输入第{0}个订单的货物名称：", countSort);
                goodsName = Console.ReadLine();

                Console.Write("请输入第{0}个订单的货物编号：", countSort);
                goodsNumber = Console.ReadLine();

                List<Order> ordListQuery = new List<Order>();
                int isExist = 0;
                foreach (Order ord in ordListQuery)
                {
                    if (ord.OrdNum == ordNum)
                    {
                        Console.WriteLine("订单的订单编号不可相同！");
                        isExist++;
                        break;
                    }
                }
                if (isExist == 1)
                    continue;
                ordList.Add(new Order(ordNum, ordName, goodsAmount, goodsName, goodsNumber)); //创建一个订单对象
                count++;
                totalAdd--;

                #region
                if (totalAdd == 0)   //输入订单到最后一个时提醒是否继续输入
                {
                    Console.Write("你已经输入{0}个订单，是否继续<y> OR <n>？", count);
                    string isContunue = Console.ReadLine();

                    if (isContunue == "y" || isContunue == "Y")
                    {
                        try
                        {
                            totalAdd = int.Parse(Console.ReadLine());
                            if (totalAdd < 1)
                                throw new Exception();
                        }
                        catch
                        {
                            Console.WriteLine("请输入一个正整数");
                        }
                    }

                }
                #endregion
            }
            faOper.OrdWrite(ordList);  //将数组中的订单信息写到文件中
        }

        //读取订单信息
        public void ReadAllOrd()
        {
            List<Order> ordList = new List<Order>();

            ordList = faOper.OrdRead();
            Console.WriteLine("\t订单编号\t订单名称\t货物数量\t货物名称\t货物编号");

            if (ordList.Count == 0)
            {
                Console.WriteLine("数据库中没有订单！");
                return;
            }

            foreach (Order ord in ordList)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", ord.OrdNum, ord.OrdName, ord.GoodsAmount, ord.GoodsName, ord.GoodsNumber);
            }
        }

        //删除指定订单信息
        public void DeleteNum(int num)
        {
            faOper.DeleteOrd(num);

        }

        //按订单编号查询订单信息
        public void QueryOrd(int num)
        {
            List<Order> ordList = faOper.OrdRead();
            int count = 0;

            Console.WriteLine("\t订单编号\t订单名称\t货物数量\t货物名称\t货物编号");
            foreach (Order ord in ordList)
            {
                if (ord.OrdNum == num)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", ord.OrdNum, ord.OrdName, ord.GoodsAmount, ord.GoodsName, ord.GoodsNumber);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("\t数据库中没该订单！");
            }
        }
        //按订单名称查询订单信息
        public void QueryOrd(string name)
        {
            List<Order> ordList = faOper.OrdRead();
            int count = 0;

            Console.WriteLine("\t订单编号\t订单名称\t货物数量\t货物名称\t货物编号");
            foreach (Order ord in ordList)
            {
                if (ord.OrdName == name)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", ord.OrdNum, ord.OrdName, ord.GoodsAmount, ord.GoodsName, ord.GoodsNumber);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("\t数据库中没该订单！");
            }
        }
        
    }


    class UserOperate
    {
        //登录判断
        public static int ShowLogin()
        {
            
            int flag = 0;  // 登陆成功标志位
            for (int i = 0; i < 3; i++)
            {
                Console.Write("请输入登录名：（此处默认的登录名为“sa”,密码为：“123”）\n");
                string userName = Console.ReadLine();

                Console.Write("请输入密码：");
                string password = Console.ReadLine();

                if (userName == "sa" && password == "123")
                {
                    Console.WriteLine("现在是{0}，恭喜你登陆成功！", DateTime.Now);
                    flag = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry，用户名或密码错误，你还有{0}次机会", 2 - i);
                }
            }

            return flag;
        }

        //程序操作主菜单
        public static int MainMenu()
        {
            string flag = "y"; //结束标志位
            int select = 0; //选择菜单项
            OrderManger sm = new OrderManger();//创建一个订单管理类

            while (flag == "y" || flag == "Y")
            {
                Console.WriteLine("\t1.添加订单信息\n\t2.删除订单信息\n\t3.查询所有订单信息\n\t4.按订单编号查询订单信息\n\t5.按订单名称查询订单信息\n\t6.退出系统");
                Console.Write("请选择：");
                try
                {
                    select = int.Parse(Console.ReadLine());
                    if (select < 1 || select > 7)
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine("请输入1~7的整数");
                    continue;
                }

                switch (select)
                {
                    case 1:
                        sm.AddOrder();//添加订单信息
                        break;
                    case 2:
                        Console.Write("请输入要删除订单的订单编号：");
                        int num;
                        while (true)
                        {
                            try
                            {
                                num = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("订单编号为整数请重新输入：");
                            }
                        }
                        sm.DeleteNum(num);
                        break;
                    //删除订单信息
                    case 3:
                        sm.ReadAllOrd();
                        break;
                    //查询所有订单信息
                    case 4:
                        Console.Write("请输入要查询订单的订单编号：");
                        int num1;
                        while (true)
                        {
                            try
                            {
                                num1 = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("订单编号为整数请重新输入：");
                            }
                        }
                        sm.QueryOrd(num1);
                        break;
                    //按订单编号查询订单信息
                    case 5:
                        Console.Write("请输入要查询订单的订单名称：");
                        string name = string.Format(Console.ReadLine());
                        sm.QueryOrd(name);
                        //按订单名称查询订单信息
                        break;
                    case 6:
                        return 0;
                    //退出系统
                    default:
                        Console.WriteLine("你的输入有误");
                        break;
                }

            }
            return 1;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int flagLogin = UserOperate.ShowLogin();//三次登录机会全失败，返回0
            int flagMenu = UserOperate.MainMenu();//退出程序返回0

            if (flagLogin == 0 || flagMenu == 0)
            {
                return;
            }
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using OrderManage.OrderManagement;


namespace OrderManage
{
    
    //using System.Collections;
    
    namespace OrderManagement
    {
        /*添加一个文件读写类FileAccess，至少包括2个方法，文件的读方法和文件写方法。
         * 读方法设计时，需要用到集合类，将读取到的所有订单添加到该集合，
         * 例如arraylist；写方法设计时，注意每次向文件写入一行,即每个订单占去一行。*/

        class FileAccessOperate
        {
            static string txtDictionary = @"e:\c#\OrderManage\";
            //写方法
            public void OrdWrite(List<Order> ordList)
            {
                string path = txtDictionary + "ord.txt";    //订单信息存储路径

                FileInfo fi = new FileInfo(path);

                //判断文件是否存在
                if (fi.Exists == false)
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    fs.Close();
                    fi = new FileInfo(path);
                }
                //判断文件是否为空，即是否是第一次序列化存储
                if (fi.Length > 0)
                {
                    //如果不为空，即已经进行过序列化存储，需将之前存的信息，反序列化读取，添加到要存储的对象集，覆盖存储
                    List<Order> OrdListRead = OrdRead();

                    foreach (Order ord in OrdListRead)
                    {
                        ordList.Add(ord);
                    }
                }

                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter(); //创建序列化对象 

                //序列化
                bf.Serialize(stream, ordList);
                stream.Close();
            }

            //删除订单
            public void DeleteOrd(int num)
            {
                List<Order> ordList = OrdRead();

                for (int i = 0; i < ordList.Count; i++)
                {
                    if (ordList[i].OrdNum == num)
                        ordList.Remove(ordList[i]);
                }

                string path = txtDictionary + "ord.txt";    //订单信息存储路径
                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter(); //创建序列化对象 

                bf.Serialize(stream, ordList);
                stream.Close();
            }

            //读方法
            public List<Order> OrdRead()
            {
                string path = txtDictionary + "ord.txt";    //订单信息存储路径

                FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter(); //创建序列化对象
                List<Order> ordList;

                ordList = bf.Deserialize(stream) as List<Order>;

                stream.Close();
                return ordList;
            }

        }
    }




    [Serializable]
    class Order
    {
        private int ordNum;  //订单编号

        public int OrdNum
        {
            get { return ordNum; }
            set { ordNum = value; }
        }

        private string ordName;  //订单名称

        public string OrdName
        {
            get { return ordName; }
            set { ordName = value; }
        }

        private string goodsAmount;     //货物数量

        public string GoodsAmount
        {
            get { return goodsAmount; }
            set { goodsAmount = value; }
        }

        private string goodsName;    //货物名称

        public string GoodsName
        {
            get { return goodsName; }
            set { goodsName = value; }
        }

        private string goodsNumber;    //货物编号

        public string GoodsNumber
        {
            get { return goodsNumber; }
            set { goodsNumber = value; }
        }

        //构造函数初始化
        public Order(int ordNum, string ordName, string goodsAmount, string goodsName, string goodsNumber)
        {
            this.ordNum = ordNum;
            this.ordName = ordName;
            this.goodsAmount = goodsAmount;
            this.goodsName = goodsName;
            this.goodsNumber = goodsNumber;
        }
    }

    class OrderManger
    {

        FileAccessOperate faOper = new FileAccessOperate();

        //添加订单信息方法
        public void AddOrder()
        {
            List<Order> ordList = new List<Order>();

            Console.Write("请输入要添加订单的订单数：");
            int totalAdd = 0; //每次输入的订单数
            int count = 0;  //记录一个输入的订单数
            //Order[] ordArr=new Order[100];  //记录订单的数组
            int ordNum; //订单属性，初始化
            string ordName, goodsAmount, goodsName, goodsNumber;

            //判断输入是否正确           
            try
            {
                totalAdd = int.Parse(Console.ReadLine());
                if (totalAdd < 1)
                    throw new Exception();
            }
            catch
            {
                Console.WriteLine("请输入一个正整数");
            }

            while (totalAdd > 0)
            {
                int countSort = count + 1;
                Console.Write("请输入第{0}个订单的订单编号：", countSort);
                ordNum = int.Parse(Console.ReadLine());

                Console.Write("请输入第{0}个订单的订单名称：", countSort);
                ordName = Console.ReadLine();

                Console.Write("请输入第{0}个订单的货物数量：", countSort);
                goodsAmount = Console.ReadLine();

                Console.Write("请输入第{0}个订单的货物名称：", countSort);
                goodsName = Console.ReadLine();

                Console.Write("请输入第{0}个订单的货物编号：", countSort);
                goodsNumber = Console.ReadLine();

                List<Order> ordListQuery = new List<Order>();
                int isExist = 0;
                foreach (Order ord in ordListQuery)
                {
                    if (ord.OrdNum == ordNum)
                    {
                        Console.WriteLine("订单的订单编号不可相同！");
                        isExist++;
                        break;
                    }
                }
                if (isExist == 1)
                    continue;
                ordList.Add(new Order(ordNum, ordName, goodsAmount, goodsName, goodsNumber)); //创建一个订单对象
                count++;
                totalAdd--;

                #region
                if (totalAdd == 0)   //输入订单到最后一个时提醒是否继续输入
                {
                    Console.Write("你已经输入{0}个订单，是否继续<y> OR <n>？", count);
                    string isContunue = Console.ReadLine();

                    if (isContunue == "y" || isContunue == "Y")
                    {
                        try
                        {
                            totalAdd = int.Parse(Console.ReadLine());
                            if (totalAdd < 1)
                                throw new Exception();
                        }
                        catch
                        {
                            Console.WriteLine("请输入一个正整数");
                        }
                    }

                }
                #endregion
            }
            faOper.OrdWrite(ordList);  //将数组中的订单信息写到文件中
        }

        //读取订单信息
        public void ReadAllOrd()
        {
            List<Order> ordList = new List<Order>();

            ordList = faOper.OrdRead();
            Console.WriteLine("\t订单编号\t订单名称\t货物数量\t货物名称\t货物编号");

            if (ordList.Count == 0)
            {
                Console.WriteLine("数据库中没有订单！");
                return;
            }

            foreach (Order ord in ordList)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", ord.OrdNum, ord.OrdName, ord.GoodsAmount, ord.GoodsName, ord.GoodsNumber);
            }
        }

        //删除指定订单信息
        public void DeleteNum(int num)
        {
            faOper.DeleteOrd(num);

        }

        //按订单编号查询订单信息
        public void QueryOrd(int num)
        {
            List<Order> ordList = faOper.OrdRead();
            int count = 0;

            Console.WriteLine("\t订单编号\t订单名称\t货物数量\t货物名称\t货物编号");
            foreach (Order ord in ordList)
            {
                if (ord.OrdNum == num)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", ord.OrdNum, ord.OrdName, ord.GoodsAmount, ord.GoodsName, ord.GoodsNumber);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("\t数据库中没该订单！");
            }
        }
        //按订单名称查询订单信息
        public void QueryOrd(string name)
        {
            List<Order> ordList = faOper.OrdRead();
            int count = 0;

            Console.WriteLine("\t订单编号\t订单名称\t货物数量\t货物名称\t货物编号");
            foreach (Order ord in ordList)
            {
                if (ord.OrdName == name)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}", ord.OrdNum, ord.OrdName, ord.GoodsAmount, ord.GoodsName, ord.GoodsNumber);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("\t数据库中没该订单！");
            }
        }
        
    }


    class UserOperate
    {
        //登录判断
        public static int ShowLogin()
        {
            
            int flag = 0;  // 登陆成功标志位
            for (int i = 0; i < 3; i++)
            {
                Console.Write("请输入登录名：（此处默认的登录名为“sa”,密码为：“123”）\n");
                string userName = Console.ReadLine();

                Console.Write("请输入密码：");
                string password = Console.ReadLine();

                if (userName == "sa" && password == "123")
                {
                    Console.WriteLine("现在是{0}，恭喜你登陆成功！", DateTime.Now);
                    flag = 1;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry，用户名或密码错误，你还有{0}次机会", 2 - i);
                }
            }

            return flag;
        }

        //程序操作主菜单
        public static int MainMenu()
        {
            string flag = "y"; //结束标志位
            int select = 0; //选择菜单项
            OrderManger sm = new OrderManger();//创建一个订单管理类

            while (flag == "y" || flag == "Y")
            {
                Console.WriteLine("\t1.添加订单信息\n\t2.删除订单信息\n\t3.查询所有订单信息\n\t4.按订单编号查询订单信息\n\t5.按订单名称查询订单信息\n\t6.退出系统");
                Console.Write("请选择：");
                try
                {
                    select = int.Parse(Console.ReadLine());
                    if (select < 1 || select > 7)
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine("请输入1~7的整数");
                    continue;
                }

                switch (select)
                {
                    case 1:
                        sm.AddOrder();//添加订单信息
                        break;
                    case 2:
                        Console.Write("请输入要删除订单的订单编号：");
                        int num;
                        while (true)
                        {
                            try
                            {
                                num = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("订单编号为整数请重新输入：");
                            }
                        }
                        sm.DeleteNum(num);
                        break;
                    //删除订单信息
                    case 3:
                        sm.ReadAllOrd();
                        break;
                    //查询所有订单信息
                    case 4:
                        Console.Write("请输入要查询订单的订单编号：");
                        int num1;
                        while (true)
                        {
                            try
                            {
                                num1 = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("订单编号为整数请重新输入：");
                            }
                        }
                        sm.QueryOrd(num1);
                        break;
                    //按订单编号查询订单信息
                    case 5:
                        Console.Write("请输入要查询订单的订单名称：");
                        string name = string.Format(Console.ReadLine());
                        sm.QueryOrd(name);
                        //按订单名称查询订单信息
                        break;
                    case 6:
                        return 0;
                    //退出系统
                    default:
                        Console.WriteLine("你的输入有误");
                        break;
                }

            }
            return 1;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int flagLogin = UserOperate.ShowLogin();//三次登录机会全失败，返回0
            int flagMenu = UserOperate.MainMenu();//退出程序返回0

            if (flagLogin == 0 || flagMenu == 0)
            {
                return;
            }
            Console.ReadKey();
        }
    }
}
