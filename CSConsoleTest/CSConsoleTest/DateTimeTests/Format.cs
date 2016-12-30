using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateTimeTests
{
    class Format
    {
        public void TestFormat()
        {
            var d = System.DateTime.Now;
            Console.WriteLine(d.ToString("dd-MMM-yyyy hh:mm:ss.ff tt"));
            Console.WriteLine(d.ToString("dd-MMM-yyyy hh:mm:ss.ffff tt"));
            Console.WriteLine(d.ToString("dd-MMM-yyyy hh:mm:ss.ffffff tt"));
            Console.WriteLine(d.ToString("dd-MMM-yyyy hh:mm:ss.fffffff tt"));
        }
    }
}
