using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace gridManager
{

    public class CryptoAES256CBC
    {
        private static readonly string keyValue = "01234567890123456789012345678901";
        private static readonly string KEY_128 = keyValue.Substring(0, 128 / 8);

        private static string encryptAES128(string plain) {
            try {
                byte[] plainBtyes = Encoding.UTF8.GetBytes(plain);
                RijndaelManaged aes = new RijndaelManaged();
                aes.KeySize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                MemoryStream memoryStream = new MemoryStream();

                ICryptoTransform encryptor = aes.CreateEncryptor(Encoding.UTF8.GetBytes(KEY_128), Encoding.UTF8.GetBytes(KEY_128));
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainBtyes, 0, plainBtyes.Length);
                cryptoStream.FlushFinalBlock();

                byte[] encrytBytes = memoryStream.ToArray();
                string encrypString = Convert.ToBase64String(encrytBytes);

                cryptoStream.Close();
                memoryStream.Close();

                return encrypString;
            } catch (Exception) {
                return null;
            }
        }


        private static string decryptAES128(string encrypt) { 
            try {
                byte[] encryptBytes = Convert.FromBase64String(encrypt);

                RijndaelManaged aes = new RijndaelManaged();

                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 128;

                MemoryStream memoryStream = new MemoryStream(encryptBytes);

               
                ICryptoTransform decryptor = aes.CreateDecryptor(Encoding.UTF8.GetBytes(KEY_128), Encoding.UTF8.GetBytes(KEY_128));
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

                byte[] plainBtytes = new byte[encrypt.Length];

                int plainCount = cryptoStream.Read(plainBtytes, 0, plainBtytes.Length);

                string plainString = Encoding.UTF8.GetString(plainBtytes, 0, plainCount);

                cryptoStream.Close();
                memoryStream.Close();

                return plainString;
            } catch (Exception){
                return null;
            }
        }

        public static string privateEncrypt(string encrypt) {
            return encryptAES128(encrypt);
        }
        public static string privateDecrypt(string decrypt) { 
            return decryptAES128(decrypt);
        }
    }

    public class Encrypt { 
        public string AES_Enc(string Encrypt) { 
            try {
                string response = CryptoAES256CBC.privateEncrypt(Encrypt);
                return response;
            } catch (Exception ex) {
                throw ex;
            }
        }
    }

    public class Decrypt {
        public string AES_Dec(string Decrypt) {
            try
            {
                string response = CryptoAES256CBC.privateDecrypt(Decrypt);
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


