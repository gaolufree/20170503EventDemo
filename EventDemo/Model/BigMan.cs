using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo.Model
{
    public class BigMan
    {
        public event EventHandler<HumanArgs> OnStartHandler;
        public HumanArgs args=new HumanArgs();
        public void DoSmothing()
        {
            Console.WriteLine("事件开始.....");
            if (OnStartHandler != null)
            {
                OnStartHandler(this, args);
            }
            Console.WriteLine("事件结束.....");
         
        }
    }
}
