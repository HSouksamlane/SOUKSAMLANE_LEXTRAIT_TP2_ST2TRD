using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOUKSAMLANE_LEXTRAIT_TP2
{
    public class Binary
    {
        public static string Code(string inputText, bool toDecrypt)
        {
            // Ternary operator - Google it
            return toDecrypt ? Decrypt(inputText) : Encrypt(inputText);
        }

        //This function converts the user's input into a 8 bytes format
        private static String input_formatting(String inputText)
        {
            String formatting_input = new string('0', 8 - (inputText.Length%8) );

            formatting_input = formatting_input + inputText;
            return formatting_input;
        }
        private static string Binary_encryption(string inputText, bool encryption_decryption)
        {
            if (string.IsNullOrEmpty(inputText))
            {
                return inputText;
            }
            if (encryption_decryption == true)
            {
                inputText = input_formatting(inputText);

                if (Convert.ToInt32(inputText,2)<32)
                {
                    return "Sorry, your Binary input does not correspond to any character/number/sign in the ASCII table :(";
                }

                List<Byte> input_byteList = new List<byte>();

                for (int i = 0; i < inputText.Length; i += 8)
                {
                    input_byteList.Add(Convert.ToByte(inputText.Substring(i, 8), 2));

                }
                return Encoding.ASCII.GetString(input_byteList.ToArray());
            }
            StringBuilder SB = new StringBuilder();

            foreach (char c in inputText.ToCharArray())
            {
                SB.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }

            return SB.ToString();



        }

        private static string Encrypt(string inputText)
        {
            return $"{Binary_encryption(inputText, false)}";
        }

        private static string Decrypt(string inputText)
        {
            return $"{Binary_encryption(inputText, true)}";
        }
    }
}
