using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sisbro_LIB
{
    public class Cryptography
    {
        public static byte[] EncryptAes(string plainText, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.CBC;

                aes.GenerateIV();
                byte[] ivBytes = aes.IV;

                using (var encryptor = aes.CreateEncryptor())
                {
                    byte[] encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    byte[] encryptedIvAndTextBytes = new byte[ivBytes.Length + encryptedBytes.Length];
                    Array.Copy(ivBytes, 0, encryptedIvAndTextBytes, 0, ivBytes.Length);
                    Array.Copy(encryptedBytes, 0, encryptedIvAndTextBytes, ivBytes.Length, encryptedBytes.Length);

                    return encryptedIvAndTextBytes;
                }
            }
        }

        public static string DecryptAes(byte[] encryptedBytes, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            using (Aes aes = Aes.Create())
            {
                aes.Key = keyBytes;
                aes.Mode = CipherMode.CBC;

                byte[] ivBytes = new byte[aes.IV.Length];
                Array.Copy(encryptedBytes, 0, ivBytes, 0, ivBytes.Length);
                aes.IV = ivBytes;

                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] encryptedTextBytes = new byte[encryptedBytes.Length - ivBytes.Length];
                    Array.Copy(encryptedBytes, ivBytes.Length, encryptedTextBytes, 0, encryptedTextBytes.Length);

                    byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedTextBytes, 0, encryptedTextBytes.Length);
                    string decryptedText = Encoding.UTF8.GetString(decryptedBytes);
                    return decryptedText;
                }
            }
        }
    }
}
