using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using System.IO;

namespace Tools.tools
{
    public class AES
    {
        public enum Md5DataType
        {
            t16 = 16,
            t32 = 32,
            t64 = 64,
        }
        public static byte[] Md5(string strSource, Md5DataType Code = Md5DataType.t32)
        {
            HashAlgorithm HA = (HashAlgorithm)CryptoConfig.CreateFromName("MD5");
            byte[] dataToHash = (new UTF8Encoding()).GetBytes(strSource);
            byte[] hashvalue = HA.ComputeHash(dataToHash);
            return hashvalue;
        }
        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="plainText"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        public static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            //检测参数
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            //创建一个AES对象
            //指定key和向量（IV）
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // 创建用于加密的流。
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //将所有数据写入流。
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            //从内存流返回加密的字节。
            return encrypted;
        }
        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="cipherText"></param>
        /// <param name="Key"></param>
        /// <param name="IV"></param>
        /// <returns></returns>
        public static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            //检测参数
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            //声明用于保留的字符串
            //解密的文本。
            string plaintext = null;
            //创建一个Aes对象
            //使用指定的key和IV。
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            //从解密流中读取解密的字节
                            //并将它们放在字符串中。
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}

