using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    /// <summary>
    /// コピーの速度をテスト
    /// </summary>
    public class CopySpeedTest
    {
        static byte[] source = new byte[1024 * 1024];
        static byte[] destination = new byte[512 * 1024];
        const int LoopCount = 1024;
        public static void Run()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();
            Console.WriteLine($"{nameof(CopySpeedTest)}.{nameof(Run)} : {nameof(LoopCount)}={LoopCount}");
            /*　一例
Array_CopyTest       : 265ms
Buffer_BlockCopyTest : 479ms
Skip_TakeTest        : 13806ms
GetRangeTest         : 86153ms
             */
            var stopwatch = new Stopwatch();

            stopwatch.Restart();
            for (int i = 0; i < LoopCount; i++)
            {
                Array_CopyTest();
            }
            stopwatch.Stop();
            Console.WriteLine($"{nameof(Array_CopyTest)} : {stopwatch.ElapsedMilliseconds}ms");

            stopwatch.Restart();
            for (int i = 0; i < LoopCount; i++)
            {
                Buffer_BlockCopyTest();
            }
            stopwatch.Stop();
            Console.WriteLine($"{nameof(Buffer_BlockCopyTest)} : {stopwatch.ElapsedMilliseconds}ms");

#if fase
            stopwatch.Restart();
            for (int i = 0; i < LoopCount; i++)
            {
                buffer = Skip_TakeTest();
            }
            stopwatch.Stop();
            Console.WriteLine($"{nameof(Skip_TakeTest)} : {stopwatch.ElapsedMilliseconds}ms");

            stopwatch.Restart();
            for (int i = 0; i < LoopCount; i++)
            {
                buffer = GetRangeTest();
            }
            stopwatch.Stop();
            Console.WriteLine($"{nameof(GetRangeTest)} : {stopwatch.ElapsedMilliseconds}ms");
#endif
        }
        public static byte[] Array_CopyTest()
        {
            Array.Copy(source, 0, destination, 0, destination.Length);
            return destination;
        }
        public static byte[] Buffer_BlockCopyTest()
        {
            Buffer.BlockCopy(source, 0, destination, 0, destination.Length);
            return destination;
        }
        public static byte[] Skip_TakeTest()
        {
            return source.Skip(0).Take(destination.Length).ToArray();
        }
        public static byte[] GetRangeTest()
        {
            ArrayList arrayList = new ArrayList(source);
            ArrayList buffer = arrayList.GetRange(0, destination.Length);
            return (byte[])buffer.ToArray(typeof(byte));
        }
    }
}
