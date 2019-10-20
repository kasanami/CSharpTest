using System;
using System.Linq;
using System.Text;

namespace CSharpTest.System.Text
{
    public class EncodingTest
    {
        public static void JapaneseTest()
        {
            Console.WriteLine($"====================");
            Ksnm.Debug.WriteLineCallerInfo();

            // 全てのエンコーディング情報
            var allEncodings = Encoding.GetEncodings();
            Console.WriteLine($"全てのエンコーディング情報 {allEncodings.Length}個");

            var japaneseEncodings = allEncodings.Where(item => item.DisplayName.Contains("日本語"));
            Console.WriteLine($"{"CodePage",-8} {"Name",-16} {"DisplayName"}");
            foreach (var item in japaneseEncodings)
            {
                Console.WriteLine($"{item.CodePage,-8} {item.Name,-16} {item.DisplayName}");
            }

            Console.WriteLine("別名で取得");
            var ShiftJISAlias = new[]
            {
                "csShiftJIS",
                "csWindows31J",
                "ms_Kanji",
                "shift-jis",
                "x-ms-cp932",
                "x-sjis",
            };
            Console.WriteLine($"{"CodePage",-8} {"Name",-16}");
            foreach (var name in ShiftJISAlias)
            {
                var item = Encoding.GetEncoding(name);
                Console.WriteLine($"{item.CodePage,-8} {name,-16}");
            }
        }
    }
}
