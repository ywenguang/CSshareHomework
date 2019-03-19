using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace clock3
{
    //功能:当起床铃声响起,就引发学生起床/厨师做早餐两个事件
    // 定义一个委托（也可以定义在Ring类里面）
    public delegate void DoSomething();
    class Program
    {
        static void Main(string[] args)
        {
            TimeCount tc = new TimeCount();
            tc.time_cnt();
        }

    }

    public class TimeCount
    {
        public void Tip_messages()
        {
            Console.WriteLine("请输入倒计时的时分秒,此时间表示在**时**分**秒后倒计时结束，闹铃响起\n注意：" +
                    "在输入数字测试时数字类型为int，因此只能按enter输入下一个数字，\n不能按space键,且输入的第一个数字为时，" +
                    "第二个数字表示分，第三个数字表示秒");
        }
        public void time_cutdown(DateTime _timeEnd)
        {
            ThreadPool.QueueUserWorkItem((arg) =>
            {
                TimeSpan _ts = _timeEnd - DateTime.Now;
                while (true)
                {
                    Thread.Sleep(1000);
                    if (_ts.TotalSeconds >= 0)
                    {
                        Console.WriteLine("倒计时{0}时{1}分钟{2}秒\n", _ts.Hours, _ts.Minutes, _ts.Seconds);
                        _ts = _ts.AddSeconds(-1);
                    }
                    else if (_ts.Hours == 0 && _ts.Minutes == 0 && _ts.Seconds == 0)
                    {
                        eventHappens eh = new eventHappens();
                        eh.event_hapen();
                        break;
                    }
                }
            });
        }
        public void time_cnt()
        {

            try
            {
                int hours, minutes, seconds;
                Tip_messages();
                Console.WriteLine("倒计时：{0}时{1}分{2}秒", hours = Convert.ToInt16(Console.ReadLine()), 
                                                            minutes = Convert.ToInt16(Console.ReadLine()),
                                                            seconds = Convert.ToInt16(Console.ReadLine()));
                int sumSeconds = hours * 3600 + minutes * 60 + seconds;
                DateTime _timeEnd = DateTime.Now.AddSeconds(sumSeconds);
                time_cutdown(_timeEnd);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                Console.ReadLine();
            }
        }
    }
    


    public static class TimeSpanToolV2
    {

        public static TimeSpan AddSeconds(this TimeSpan ts, int seconds)
        {
            return ts.Add(new TimeSpan(0, 0, seconds));
        }
        public static TimeSpan AddMinutes(this TimeSpan ts, int minutes)
        {
            return ts.Add(new TimeSpan(0, minutes, 0));
        }
        public static TimeSpan AddHours(this TimeSpan ts, int hours)
        {
            return ts.Add(new TimeSpan(hours, 0, 0));
        }
    }
      


    // 产生事件的类 
    public class Ring
    {
        // 声明一个委托事件
        public event DoSomething doIt;

        // 构造函数
        public Ring()
        {
        }

        // 定义一个方法,即"响铃"   引发一个事件
        public void RaiseEvent()
        {
            Console.WriteLine("铃声响了");

            // 判断事件是否有调用委托（是不是要求叫学生起床，叫厨师做饭）
            if (null != doIt)
            {
                doIt(); //  如果有注册的对象，那就调用委托（叫学生起床，叫厨师做饭）
            }
            else
            {
                Console.WriteLine("无事发生"); //没有注册，事件没有调用任何委托
            }
        }
    }

    // 学生类( 处理事件类一)
    public class HandleEventOfStudents
    {
        // 默认构造函数
        public HandleEventOfStudents()
        {
        }

        //叫学生起床
        public void GetUp()
        {
            Console.WriteLine("[学生]:听到起床铃声响了，起床了。");
        }
    }

    //  校园厨师类(处理事件类二)  
    public class HandleEventOfChefs
    {
        // 默认构造函数
        public HandleEventOfChefs()
        {
        }

        //叫厨师做早餐
        public void Cook()
        {
            Console.WriteLine("[厨师]:听到起床铃声响了，为学生做早餐。");
        }
    }

    public class eventHappens
    {
        public void event_hapen()
        {
            Ring ring = new Ring(); // 实例化一个铃声类[它是主角,都是因为它才牵连一系列的动作]  
            ring.doIt += new HandleEventOfStudents().GetUp; // 注册，学生委托铃声类，铃声响起的时候叫我起床.
            ring.doIt += new HandleEventOfChefs().Cook;     // 注册，厨师告诉铃声类,我也委托你叫我什么时候做早餐
            ring.RaiseEvent(); // 铃声响起来了，它发现学生和厨师都拜托（注册）了自己，然后它就开始叫学生起床，叫厨师做早餐（一个事件调用了两个委托）

        }
    }


  
}
