using System;
using Ksnm.ExtensionMethods.System.Collections.Generic.Enumerable;

namespace CSharpTest.System
{
    public class DecimalTest
    {
        public static void _()
        {
            Console.WriteLine($"Zero    ={HexString(decimal.Zero)}");
            Console.WriteLine($"One     ={HexString(decimal.One)}");
            Console.WriteLine($"MinusOne={HexString(decimal.MinusOne)}");
            Console.WriteLine($"MaxValue={HexString(decimal.MaxValue)}");
            Console.WriteLine($"MinValue={HexString(decimal.MinValue)}");
        }
        static string HexString(decimal d)
        {
            return decimal.GetBits(d).ToJoinedString("_", "X8");
        }
    }
}
