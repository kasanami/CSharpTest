using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Ksnm.ExtensionMethods.System.Collections.Generic.Enumerable;

namespace CSharpTest.System.Numerics
{
    public class BigIntegerTest
    {
        public static void ToByteArrayTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            var int32 = (BigInteger)int.MaxValue;
            Console.WriteLine($"{nameof(int32)}{int32.ToByteArray().ToDebugString()}");

            var int64 = (BigInteger)long.MaxValue;
            Console.WriteLine($"{nameof(int64)}{int64.ToByteArray().ToDebugString()}");

            var bigint = (BigInteger)long.MaxValue;
            bigint *= long.MaxValue;
            Console.WriteLine($"{nameof(bigint)}{bigint.ToByteArray().ToDebugString()}");
        }
    }
}
