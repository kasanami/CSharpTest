using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class DateTimeTest
    {
        public static void All()
        {
            TicksTest();
            BinaryTest();
            ParseTest();
        }
        /// <summary>
        /// DateTimeをシリアル化した結果をみてみる
        /// </summary>
        public static void TicksTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();
            var dateTime0 = new DateTime(2000, 1, 1, 0, 0, 0);
            var dateTime1 = new DateTime(2000, 1, 1, 0, 0, 1);
            Console.WriteLine($"{nameof(dateTime0)}={dateTime0.Ticks}");
            Console.WriteLine($"{nameof(dateTime1)}={dateTime1.Ticks}");
            Console.WriteLine($"{nameof(dateTime1)}-{nameof(dateTime0)}={(dateTime1.Ticks - dateTime0.Ticks)}");
        }
        /// <summary>
        /// DateTimeをシリアル化した結果をみてみる
        /// </summary>
        public static void BinaryTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();
            foreach (var item in ((DateTimeKind[])Enum.GetValues(typeof(DateTimeKind))))
            {
                for (int i = 0; i < 3; i++)
                {
                    var dateTime = new DateTime(i, item);
                    var binary = dateTime.ToBinary();
                    var ticks = dateTime.Ticks;
                    Console.WriteLine($"DateTime({i}, {item})");
                    Console.WriteLine($"{nameof(dateTime)}={dateTime}");
                    Console.WriteLine($"{nameof(binary)}  ={binary:X16}");
                    Console.WriteLine($"{nameof(ticks)}   ={ticks:X16}");
                }
            }
            {
                var now = new DateTime(2019, 1, 1);
                foreach (var item in ((DateTimeKind[])Enum.GetValues(typeof(DateTimeKind))))
                {
                    var dateTime = new DateTime(now.Ticks, item);
                    var binary = dateTime.ToBinary();
                    var ticks = dateTime.Ticks;
                    Console.WriteLine($"DateTime({now}, {item})");
                    Console.WriteLine($"{nameof(dateTime)}={dateTime}");
                    Console.WriteLine($"{nameof(binary)}  ={binary:X16}");
                    Console.WriteLine($"{nameof(ticks)}   ={ticks:X16}");
                }
            }
        }
        public static void ParseTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();
            var str = "2019/11/22 12:34:56";
            var format = "yyyy/MM/dd HH:mm:ss";
            var dateTime = DateTime.ParseExact(str, format, null);
        }
    }
}
