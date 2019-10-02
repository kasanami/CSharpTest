using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class BufferTest
    {
        public static void CopyTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();
            // コピー元
            var ary1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // コピー先
            var ary2 = new int[5];
            var ary3 = new int[5];
            Buffer.BlockCopy(ary1, 2 * 4, ary2, 0, 5 * 4);
            Array.Copy(ary1, 2, ary3, 0, 5);
        }
    }
}
