using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WithAwait
    {
        static void Main(string[] args)
        {
            Function1WithoutAwait();
            Function2WithoutAwait();
            callFunction();
            Console.ReadKey();
        }
        public static async void callFunction()
        {
            Task<int> task = Function1WithAwait();
            Function2();
            int count = await task;
            Function3(count);
        }
        public static async Task<int> Function1WithAwait()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Function 1");
                    count += 1;
                }
            });
            return count;
        }


        public static void Function2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Function 2");
            }
        }


        public static void Function3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        public static async Task Function1WithoutAwait()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Function 1");
                }
            });
        }


        public static void Function2WithoutAwait()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Function 2");
            }
        }


    }

}
