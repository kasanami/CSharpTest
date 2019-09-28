using Ksnm.ExtensionMethods.System.Collections.Generic.Enumerable;
using System;

namespace CSharpTest.System
{
    public class ArrayTest
    {
        public static void EqualTest()
        {
            var ary1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var ary2 = ary1;
            Console.WriteLine($"ary1 == ary2 = {(ary1 == ary2)}");
            ary2[1] = 11;
            Console.WriteLine($"ary1 = {ary1.ToJoinedString(",")}");
            Console.WriteLine($"ary2 = {ary2.ToJoinedString(",")}");
        }
        public static void CloneTest()
        {
            var ary1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var ary2 = (int[])ary1.Clone();
            Console.WriteLine($"ary1 == ary2 = {(ary1 == ary2)}");
            ary2[1] = 11;
            Console.WriteLine($"ary1 = {ary1.ToJoinedString(",")}");
            Console.WriteLine($"ary2 = {ary2.ToJoinedString(",")}");
        }
        public static void CopyTest()
        {
            // コピー元
            var ary1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // コピー先
            var ary2 = new int[5];
            Array.Copy(ary1, 2, ary2, 0, 5);
        }
    }
}
