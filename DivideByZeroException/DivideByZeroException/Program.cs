using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZeroException
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1 = 10;
            int no2 = 0;
            int tot = 0;

            try
            {
                tot = no1 / no2; // DivideByZeroException thrown 
                Console.WriteLine(tot);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Integer no Divide result : " + ex.ToString());

            }
            float no3 = 10;
            float no4 = 0;

            var result = no3 / no4; // DivideByZeroException not thrown instead printing infinity
            Console.WriteLine("Float no Divide result : " + result);
        }
    }
}
