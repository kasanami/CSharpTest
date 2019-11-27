using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.System.Collections.Generic
{
    public class DictionaryTest
    {
        public static void All()
        {
            OrderByTest();
        }
        public static void OrderByTest()
        {
            var sample = new Dictionary<string, int>()
            {
                { "C", 2 },
                { "A", 1 },
                { "B", 3 },
            };
            sample = sample.OrderBy(item => item.Key)
                .ToDictionary(item => item.Key, item => item.Value);
            sample = sample.OrderBy(item => item.Value)
                .ToDictionary(item => item.Key, item => item.Value);
        }
    }
}
