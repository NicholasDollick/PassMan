using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WPFUserInterface.Helpers
{
    class CryptUtils
    {
        public const int SALT_BYTES = 128 / 8;
        public const int HASH_BYTES = 18;
        public const int PBKDF2_ITERATIONS = 32000;

        public const int DECORATOR = 0;
        public const int ITER_INDEX = 1;
        public const int SIZE_INDEX = 2;
        public const int SALT_INDEX = 3;
        public const int PBKDF2_INDEX = 4;
        public const int HASH_SECT_COUNT = 5;

        public static string CreatePBKDF2Hash(string password)
        {
            byte[] salt = new byte[SALT_BYTES];

            using (var genSalt = new RNGCryptoServiceProvider())
                genSalt.GetBytes(salt);

            byte[] hash = PBKDF2Hash(password, salt, PBKDF2_ITERATIONS, HASH_BYTES);

            // return format decorator:iteration:size:salt:hash
            return "qntm:" + PBKDF2_ITERATIONS + ":" + hash.Length + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        private static byte[] PBKDF2Hash(string pwd, byte[] salt, int iter, int size)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(pwd, salt))
            {
                pbkdf2.IterationCount = iter;
                return pbkdf2.GetBytes(size);
            }
        }

        public static bool validatePassword(string pwd, string pwdHash)
        {
            char delimit = ':';
            string[] split = pwdHash.Split(delimit);

            if (split.Length != HASH_SECT_COUNT)
                return false;

            // if this decorator does not exist, the password was not hashed by this algo
            if (split[DECORATOR] != "qntm")
                return false;

            int iterations = int.Parse(split[ITER_INDEX]);
            int hashSize = int.Parse(split[SIZE_INDEX]);
            byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            var testHash = PBKDF2Hash(pwd, salt, iterations, hashSize);

            if (testHash.SequenceEqual(hash))
                return true;

            return false;
        }

        public static string EncryptWithWindowsAcc(string text)
        {
            byte[] clearBytes = Encoding.UTF8.GetBytes(text);
            byte[] encryptedBytes = ProtectedData.Protect(clearBytes, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string DecryptWithWindowsAcc(string text)
        {
            byte[] encryptedBytes = Convert.FromBase64String(text);
            byte[] clearBytes = ProtectedData.Unprotect(encryptedBytes, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(clearBytes);
        }

        private static byte[] GetHash(string s)
        {
            byte[] bt;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                bt = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(s));
            }
            return bt;
        }

        public static byte[] exclusiveOR(byte[] h1, byte[] h2)
        {
            if (h1.Length == h2.Length)
            {
                byte[] result = new byte[h1.Length];
                for (int i = 0; i < h1.Length; i++)
                {
                    result[i] = (byte)(h1[i] ^ h2[i]);
                }
                return result;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private string GenerateDiceware(int wordAmt)
        {
            string[] wordlist;
            var listLoc = @"Assets/wordlist.txt";

            if(!File.Exists(listLoc))
            {
                System.Windows.MessageBox.Show("Error fetching word list");
                return null;
            }
            else
            {
                wordlist = File.ReadAllLines(listLoc);
            }

            //try
            //{
            //    using (var web = new System.Net.WebClient())
            //    {
            //        wordlist = web.DownloadString();
            //    }
            //}
            //catch
            //{
            //    System.Windows.MessageBox.Show("Error fetching word list");
            //}

            return null;
        }
    }
}
