using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMathFunction
{
    class Program
    {
        static void Main()
        {
            //
            // Compute two absolute values.
            //
            int value1 = -1000;
            int value2 = 20;
            int abs1 = Math.Abs(value1);
            int abs2 = Math.Abs(value2);
            //
            // Write integral results.
            //
            Console.WriteLine(value1);
            Console.WriteLine(abs1);
            Console.WriteLine(value2);
            Console.WriteLine(abs2);
            //
            // Compute two double absolute values.
            //
            double value3 = -100.123;
            double value4 = 20.20;
            double abs3 = Math.Abs(value3);
            double abs4 = Math.Abs(value4);
            //
            // Write double results.
            //
            Console.WriteLine(value3);
            Console.WriteLine(abs3);
            Console.WriteLine(value4);
            Console.WriteLine(abs4);
        }
    }
}

