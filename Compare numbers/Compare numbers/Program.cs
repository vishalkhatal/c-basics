using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_numbers
{
     public class CompareBinaryToHex 
    {
        private int DigitToValue(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return c - '0';
            }
            else if (c >= 'A' && c <= 'F')
            {
                return 10 + c - 'A';
            }
            else if (c >= 'a' && c <= 'f')
            {
                return 10 + c - 'a';
            }
            return -1;
        }

        private int ConvertToBase(string number, int bace)
        {
            if (bace < 2 || (bace > 10 && bace != 16)) return -1;
            int value = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = DigitToValue(number[i]);
                if (digit < 0 || digit >= bace)
                {
                    return -1;
                }
                int exp = number.Length - 1 - i;
                value += (int)(digit * Math.Pow(bace, exp));
            }
            return value;
        }

        private bool CompareBinToHex(String binary, String hex)
        {
            int n1 = ConvertToBase(binary, 2);
            int n2 = ConvertToBase(hex, 16);
            if (n1 < 0 || n2 < 0)
            {
                return false;
            }
            else
            {
                return n1 == n2;
            }
        }

        static void Main(string[] args)
        {
            CompareBinaryToHex cbh = new CompareBinaryToHex();
            Console.WriteLine(cbh.CompareBinToHex("111001011", "1CB"));
        }
    }

}
