using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -128; // -128 ~ 127
            byte b = 255; // 0 ~ 255
            Console.WriteLine($"a={a}");
            short c = -32768; // 32768~32767
            ushort d = 65535; // 0 ~ 65535
            int e = -2147483648;
            Console.WriteLine($"e = {e}");
            Console.WriteLine("e = " + e);

            long f = 5000_4000_3000;
            Console.WriteLine($"f={f}");
        }
    }
}
