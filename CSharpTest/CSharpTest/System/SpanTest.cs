using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class SpanTest
    {
        public static void All()
        {
            ToStringTest();
        }
        public static void ToStringTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            var span = "hoge".AsSpan();
            Console.WriteLine(span.ToString());
            span = "あいうえお".AsSpan();
            Console.WriteLine(span.ToString());
        }
    }
}
