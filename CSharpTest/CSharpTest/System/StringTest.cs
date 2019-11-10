using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class StringTest
    {
        public static void All()
        {
            SplitTest();
        }
        public static void SplitTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            var str = "a,b.c,d";
            str.Split(',', '.');
        }
    }
}
