using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class RandomTest
    {
        /// <summary>
        /// オーバーライドのテスト
        /// </summary>
        public static void OverrideTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            var random = new OverrideTestRandom();
            Console.WriteLine($"random.Next()");
            random.Next();
            Console.WriteLine($"random.Next(10)");
            random.Next(10);
            Console.WriteLine($"random.Next(1, 10)");
            random.Next(1, 10);
            Console.WriteLine($"random.NextDouble()");
            random.NextDouble();
            var buffer = new byte[10];
            Console.WriteLine($"random.NextBytes(buffer)");
            random.NextBytes(buffer);
        }
    }
}
