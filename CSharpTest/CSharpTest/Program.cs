using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CopySpeedTest.Run();
            CopySpeedTest.Run();
            CopySpeedTest.Run();
            CopySpeedTest.Run();
            System.ArrayTest.EqualTest();
            System.ArrayTest.CloneTest();
            System.BufferTest.CopyTest();
            System.DateTimeTest.TicksTest();
            System.DateTimeTest.BinaryTest();
        }
    }
}
