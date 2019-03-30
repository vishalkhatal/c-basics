using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringUniqueCharCheck
{
    class UniqueCharCheck
    {
        static void Main(string[] args)
        {
            UniqueCharCheck uc = new UniqueCharCheck();
            string[] words = { "abcde", "hello", "apple", "kite", "padle" };

            foreach (var word in words)
            {
                Console.WriteLine(word + ": " + uc.IsUniqueChars2(word));
            }
        }
      
        private bool IsUniqueChars2(String str)
        {
            var hashset = new HashSet<char>();
            foreach (var c in str)
            {
                if (hashset.Contains(c)) return false;
                hashset.Add(c);
            }

            return true;
        }

 
    }
}
