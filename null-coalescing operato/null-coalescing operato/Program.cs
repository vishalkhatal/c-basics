using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_coalescing_operato
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;

            // Set y to the value of x if x is NOT null; otherwise,
            // if x == null, set y to -1.
            int y = x ?? -1;
            Console.WriteLine("Output : " + y);

            string parm1 = null;
            string localDefault = "value2";
            string globalDefault = null;

            string anybody = parm1 ?? localDefault ?? globalDefault;  // Output: value2

            Console.Write("Output : " + anybody);
            Console.ReadKey();
        }
    }   
}
