/*
 * 
 * Developed By Gerson Aldaz [ AldazActivator ]
 * if you wanna source full dm telegram @gerson_5
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MagicCFG
{
    public static class Encriptador
    {
        public static void FileEncryptAndSave(string FileNameInput, string FileNameOutput)
        {
            // Cargar el archivo original
            string images_path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "resources/diags/");
            string filePath = Path.Combine(images_path, FileNameInput);
            byte[] data = File.ReadAllBytes(filePath);
            byte[] encryptedData = AES256Encrypt(data, EncryptionKey());
            string filePathOutput = Path.Combine(images_path, FileNameOutput);
            File.WriteAllBytes(filePathOutput, encryptedData);
        }

        public static void FileDecryptAndSave(string FileNameInput, string FileNameOutput)
        {
            // Cargar el archivo original
            string images_path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "resources/diags/");
            string filePath = Path.Combine(images_path, FileNameInput);
            byte[] data = File.ReadAllBytes(filePath);
            byte[] decryptedData = AES256Decrypt(data, EncryptionKey());
            string filePathOutput = Path.Combine(FileNameOutput);
            File.WriteAllBytes(filePathOutput, decryptedData);
        }

        private static byte[] AES256Encrypt(byte[] data, byte[] key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.ECB;
                aesAlg.Padding = PaddingMode.PKCS7;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(data, 0, data.Length);
                        csEncrypt.FlushFinalBlock();
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        private static byte[] AES256Decrypt(byte[] data, byte[] key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.Mode = CipherMode.ECB;
                aesAlg.Padding = PaddingMode.PKCS7;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(data))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        byte[] decryptedData = new byte[data.Length];
                        int decryptedLength = csDecrypt.Read(decryptedData, 0, decryptedData.Length);
                        byte[] result = new byte[decryptedLength];
                        Array.Copy(decryptedData, result, decryptedLength);
                        return result;
                    }
                }
            }
        }


        private static byte[] EncryptionKey()
        {
            // Aquí debes proporcionar la lógica para generar la clave de encriptación
            // y devolverla como un array de bytes.
            // Ejemplo:
            string encryptionKey = "InputYourKeyHere";
            return Encoding.UTF8.GetBytes(encryptionKey);
        }

        private static string ProductType { get; set; }
        private static string HW_INFO { get; set; }
        private static string TemporaryDir()
        {
            // Aquí debes proporcionar la lógica para obtener el directorio temporal
            // y devolverlo como una cadena de texto.
            // Ejemplo:
            return Path.GetTempPath();
        }
    }
}
