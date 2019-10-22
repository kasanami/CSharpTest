using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class MathTest
    {
        public static void All()
        {
            CastTest();
            PowTest();
        }
        public static void CastTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            Console.WriteLine($"double int");
            double d = double.PositiveInfinity;
            Console.WriteLine($"PositiveInfinity = {(int)d}");
            d = double.NegativeInfinity;
            Console.WriteLine($"NegativeInfinity = {(int)d}");

            try
            {
                checked
                {
                    d = double.NegativeInfinity;
                    Console.WriteLine($"NegativeInfinity = {(int)d}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e}");
            }
        }
        public static void PowTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            for (int x = -1; x <= 1; x++)
            {
                for (int e = -2; e <= 2; e++)
                {
                    var p = Math.Pow(x, e);
                    Console.WriteLine($"Math.Pow({x}, {e})={Math.Sign(p)}{p}");
                }
            }
        }
    }
}
