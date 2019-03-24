using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_string_Permutation
{
    class StringPermutation
    {
        static void Main(string[] args)
        {
            StringPermutation sc = new StringPermutation();
            string[][] pairs =
           {
                new string[]{"apple", "papel"},
                new string[]{"carrot", "tarroc"},

            };

            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var result = sc.IsPermutation(word1, word2);
                Console.WriteLine("{0}, {1}: {2}", word1, word2, result);
            }
        }
        private bool IsPermutation(string original, string valueToTest)
        {
            if (original.Length != valueToTest.Length)
            {
                return false;
            }

            var originalAsArray = original.ToCharArray();
            Array.Sort(originalAsArray);
            original = new string(originalAsArray);

            var valueToTestAsArray = valueToTest.ToCharArray();
            Array.Sort(valueToTestAsArray);
            valueToTest = new string(valueToTestAsArray);

            return original.Equals(valueToTest);
        }


    }
}
