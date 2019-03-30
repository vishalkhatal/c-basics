using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod();
            Console.ReadKey();
        }

        public static void TestMethod()
        {
            try
            {
                AsyncMethod();
            }
            catch (Exception ex)//Stmt inside this catch will never be executed.
                                //Exception thrown by AsyncMethod will never be caught
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static async void AsyncMethod()
        {
            throw new Exception();
        }
    }
}
