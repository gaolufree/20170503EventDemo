using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventDemo.Model;


namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var man=new BigMan();
            man.args.context = "倒计时事件";
            /*
             *  可以用一下来代替 static void OnEvent(object sender,HumanArgs e)
             *  man.OnStartHandler += (s, e) =>
             *  {
             *    Console.WriteLine($"执行事件:{e.context}");
             *  };
             */
            man.OnStartHandler += OnEvent;
            man.DoSmothing();
            Console.Read();
        }
        /// <summary>
        /// 如果上面被替换的话 就这个方法不要存在了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void OnEvent(object sender,HumanArgs e)
        {
            Console.WriteLine($"执行事件:{e.context}");
        }
    }
}
