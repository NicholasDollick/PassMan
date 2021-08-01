﻿using System.Security.Cryptography;
using System.Text;

namespace WPFUserInterface.Helpers
{
    class PasswordUtils
    {
        public static string GenerateStringPass(int passLength, string passType)
        {
            string CapitalLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string SmallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "0123456789";
            string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
            string AllChar = CapitalLetters + SmallLetters + Digits + SpecialCharacters;
            
            StringBuilder sb = new StringBuilder();
            for (int n = 0; n < passLength; n++)
            {
                // this will be controlled using the passType to modify the charset
                sb = sb.Append(GenerateChar(AllChar));
            }
            
            return sb.ToString();
        }

        private static char GenerateChar(string availableChars)
        {
            var byteArray = new byte[1];
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            char c;
            do
            {
                provider.GetBytes(byteArray);
                c = (char)byteArray[0];

            } while (!availableChars.Any(x => x == c));

            return c;
        }
    }
}
