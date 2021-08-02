using System.Linq;
using System.Security.Cryptography;
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

            string useSet = string.Empty;

            // TODO: revisit what is considered to be readable chars...maybe ones you can easily say out loud?
            if (passType.Equals("all"))
                useSet = AllChar;
            else if (passType.Equals("read"))
                useSet = "QWERTYUIPASDFGHJKLZXCVBNMqwertyuiopasdfghjkzxcvbnm23456789!@#$%^&*()-_=+<,>.";
            else if (passType.Equals("simple"))
                useSet = CapitalLetters + SmallLetters;
            else
                return "";

            StringBuilder sb = new StringBuilder();
            for (int n = 0; n < passLength; n++)
            {
                sb = sb.Append(GenerateChar(useSet));
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
