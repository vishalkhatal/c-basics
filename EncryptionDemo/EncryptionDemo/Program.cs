using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var OrignalStr = "rrcvs2gxihxa3husniduqo4hh2agiikyv6btfqutryubmvr3illa";
            var encryptedStr = EncodePAT(OrignalStr);
            var decryptedStr = DecodePAT(encryptedStr);
            Console.ReadKey();

        }
        private static string EncodePAT(string pat)
        {
            try
            {
                byte[] encData_byte = new byte[pat.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(pat);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        } //this function Convert to Decord your Password
        public static string DecodePAT(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
