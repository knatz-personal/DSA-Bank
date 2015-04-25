using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CommonUtils
{
    /// <summary>
    /// Hashing Util
    /// </summary>
    public static class HashingUtil
    {
        //source: http://stackoverflow.com/questions/2138429/hash-and-salt-passwords-in-c-sharp

        /// <summary>
        /// Generate Salted Hash
        /// </summary>
        /// <param name="textToHash">text To Hash</param>
        /// <param name="saltValue">salt Value</param>
        /// <returns></returns>
        public static string GenerateSaltedHash(string textToHash, string saltValue)
        {
            byte[] plainText = Encoding.UTF8.GetBytes(textToHash);
            byte[] salt = Encoding.UTF8.GetBytes(saltValue);
            HashAlgorithm algorithm = new SHA512Managed();

            var plainTextWithSaltBytes =
                new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return Convert.ToBase64String(algorithm.ComputeHash(plainTextWithSaltBytes));
        }

        /// <summary>
        /// Generate Salt Value
        /// </summary>
        /// <returns></returns>
        public static string GenerateSaltValue()
        {
            return DateTime.Now.ToFileTime().ToString(CultureInfo.InvariantCulture);
        }
    }
}