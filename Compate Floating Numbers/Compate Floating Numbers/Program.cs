using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compate_Floating_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float myNumber = 3.146f;

            if (myNumber.IsApproximately(3.146f, within: 0.001f))
            {
                Console.Write("Numbers matching");
            }
            else
            {
                Console.Write("Numbers not matching");
            }
        }
    }
    public static class FloatAndDoubleExt
    {
        public static bool IsApproximately(this double self, double other, double within)
        {
            return Math.Abs(self - other) <= within;
        }

        public static bool IsApproximately(this float self, float other, float within)
        {
            return Math.Abs(self - other) <= within;
        }
    }
}
