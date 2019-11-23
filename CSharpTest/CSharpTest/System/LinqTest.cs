using Ksnm.ExtensionMethods.System.Collections.Generic.Enumerable;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTest.System
{
    public class LinqTest
    {
        public static void All()
        {
            SelectManyTest();
        }
        public static void SelectManyTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            var list = new List<int[]>();
            list.Add(new int[] { 1, 2, 3 });
            list.Add(new int[] { 4, 5, 6 });
            list.Add(new int[] { 7, 8, 9 });

            var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var actual = list.SelectMany(item => item);

            Console.WriteLine($"{expected.ToJoinedString(",")}");
            Console.WriteLine($"{actual.ToJoinedString(",")}");
        }
    }
}
