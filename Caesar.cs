using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOUKSAMLANE_LEXTRAIT_TP2
{
    public class Caesar
    {
        public static string Code(string inputText, bool toDecrypt)
        {
            // Ternary operator - Google it
            return toDecrypt ? Decrypt(inputText) : Encrypt(inputText);
        }

        private static string Caesar_encryption(string inputText, bool encryption_decryption)
        {
            //For the Caesar encryption, we are using a shift of 2
            char shift = (char)2;
            string to_encrypt_caesar = inputText;

            //We are putting all the characters of the string in an array in order to perform the encryption
            char[] array_caesar = to_encrypt_caesar.ToCharArray();

            for (var i = 0; i < array_caesar.Length; i++)
            {
                if (encryption_decryption == false)
                {
                    if ((array_caesar[i] == 89) || (array_caesar[i] == 90) || (array_caesar[i] == 121) || (array_caesar[i] == 122))
                    {
                        array_caesar[i] = (char)(array_caesar[i] - 24);
                    }
                    else
                    {
                        array_caesar[i] = (char)(array_caesar[i] + shift);
                    }
                }
                else
                {
                    //we have replaced the + by a - for the decryption
                    if ((array_caesar[i] == 65) || (array_caesar[i] == 66) || (array_caesar[i] == 97) || (array_caesar[i] == 98))
                    {
                        array_caesar[i] = (char)(array_caesar[i] + 24);
                    }
                    else
                    {
                        array_caesar[i] = (char)(array_caesar[i] - shift);
                    }
                }
            }
            string encrypted_caesar = string.Join("", array_caesar);

            return encrypted_caesar;
        }
        private static string Encrypt(string inputText)
        {
            return $"{Caesar_encryption(inputText, false)}";
        }

        private static string Decrypt(string inputText)
        {
            return $"{Caesar_encryption(inputText, true)}";
        }
    }
}
