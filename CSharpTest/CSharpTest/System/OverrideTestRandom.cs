using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System
{
    public class OverrideTestRandom : Random
    {
        protected override double Sample()
        {
            Console.WriteLine("OverrideTestRandom.Sample()");
            return base.Sample();
        }
    }
}
