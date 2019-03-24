using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapMinMaxInArray
{
    class SwapNumbers
    {
        private static readonly Random RandomIntNumbers = new Random();
        static void Main(string[] args)
        {

        SwapNumbers sn = new SwapNumbers();
            int[] array = SwapNumbers.RandomArray(10, -10, 10);
            Console.WriteLine(SwapNumbers.ArrayToString(array));
            sn.SwapMinMaxBetter(array);
            Console.WriteLine(SwapNumbers.ArrayToString(array));
        }
        public static int RandomInt(int n)
        {
            return RandomIntNumbers.Next(n);
        }

        public static int RandomIntInRange(int min, int max)
        {
            return RandomInt(max + 1 - min) + min;
        }
        public static int[] RandomArray(int N, int min, int max)
        {
            int[] array = new int[N];
            for (int j = 0; j < N; j++)
            {
                array[j] = RandomIntInRange(min, max);
            }
            return array;
        }
        public static string ArrayToString(int[] array)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int v in array)
            {
                sb.AppendFormat("{0}, ", v);
            }
            return sb.ToString();
        }
        private int GetMinIndex(int[] array)
        {
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        private int GetMaxIndex(int[] array)
        {
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void Swap(int[] array, int m, int n)
        {
            int temp = array[m];
            array[m] = array[n];
            array[n] = temp;
        }

        private void SwapMinMaxBetter(int[] array)
        {
            int minIndex = GetMinIndex(array);
            int maxIndex = GetMaxIndex(array);
            Swap(array, minIndex, maxIndex);
        }

    }
}
