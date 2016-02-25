using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime b = new DateTime(1986, 1, 26);
            Console.WriteLine("现在是：" + now.ToLongDateString());
            Console.WriteLine((int)(now - b).TotalDays + "天");
            Console.WriteLine((int)(now - b).TotalHours + "小时");
            Console.Read();
        }
    }
}
