using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOUKSAMLANE_LEXTRAIT_TP2
{
    public class Vigenere
    {
        public static string Code(string inputText, string inputKey, bool toDecrypt)
        {
            // Ternary operator - Google it
            return toDecrypt ? Decrypt(inputText, inputKey) : Encrypt(inputText, inputKey);
        }

        private static String key_generator(String inputText, String inputKey)
        {
            int key_length = inputText.Length;

            for (int i = 0; ; i++)
            {
                if (key_length == i)
                    i = 0;

                if (inputKey.Length == inputText.Length)
                    break;
                inputKey += (inputKey[i]);
            }
            return inputKey;
        }

        public static string Vigenere_encryption(string inputText, string key, bool encryption_decryption)
        {

            if (string.IsNullOrEmpty(inputText))
            {
                return inputText;
            }

            if (encryption_decryption == false)
            {
                String encrypted_Vigenere = "";

                for (int i = 0; i < key.Length; i++)
                {
                    int x = (inputText[i] + key[i]) % 26;
                    x += 'A';
                    encrypted_Vigenere += (char)(x);

                }
                return encrypted_Vigenere;
            }

            else
            {
                String decrypted_Vigenere = "";

                for (int j = 0; j < inputText.Length && j < key.Length; j++)
                {
                    int y = (inputText[j] - key[j] + 26) % 26;
                    y += 'A';
                    decrypted_Vigenere += (char)(y);
                }
                return decrypted_Vigenere;
            }
        }

        private static string Encrypt(string inputText, string vigenere_key)
        {

            return $"{Vigenere_encryption(inputText, key_generator(inputText, vigenere_key), false)}";
        }

        private static string Decrypt(string inputText, string vigenere_key)
        {
            return $"{Vigenere_encryption(inputText, key_generator(inputText, vigenere_key), true)}";
        }
    }
}
