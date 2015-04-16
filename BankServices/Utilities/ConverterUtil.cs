using System;

namespace WebPortal.Utilities
{
    /// <summary>
    /// Type Converter Utility
    /// </summary>
    public static class ConverterUtil
    {
        /// <summary>
        /// Get Bytes from string
        /// </summary>
        /// <param name="text">text</param>
        /// <returns></returns>
        public static byte[] GetBytes(string text)
        {
            var bytes = new byte[text.Length*sizeof (char)];
            Buffer.BlockCopy(text.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        /// <summary>
        /// Get String from byte array
        /// </summary>
        /// <param name="byteArray">byte Array</param>
        /// <returns></returns>
        public static string GetString(byte[] byteArray)
        {
            var chars = new char[byteArray.Length/sizeof (char)];
            Buffer.BlockCopy(byteArray, 0, chars, 0, byteArray.Length);
            return new string(chars);
        }
    }
}