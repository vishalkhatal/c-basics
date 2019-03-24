using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumbers
{
    class SwapNumber
    {
        public void SwapNumbers(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void Main(string[] args)
        {
            SwapNumber sn = new SwapNumber();
            var a = 5;
            var b = 10;
            Console.WriteLine($"Before {a}   {b}");
            sn.SwapNumbers(ref a, ref b);
            Console.WriteLine($"After  {a}   {b}");
        }
    }
}
