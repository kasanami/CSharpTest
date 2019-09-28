using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class ArrayTest
    {
        public void CopyTest()
        {
            // コピー元
            var ary1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // コピー先
            var ary2 = new int[5];
            Array.Copy(ary1, 2, ary2, 0, 5);
        }
    }
}
