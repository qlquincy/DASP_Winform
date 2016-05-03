using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace DASP.Tools
{
    public class FileOperationUtils
    {
        /// <summary>
        /// 移动指定的文件到指定的目录
        /// </summary>
        /// <param name="filePath">原始文件路径</param>
        /// <param name="desDir">目录路径</param>
        /// <param name="newFileName">新文件名</param>
        public static void CopyFileToDesDir(string filePath, string desDir, string newFileName)
        {
            try
            {
                FileInfo fi = new FileInfo(filePath);
                string tmp = desDir + "\\" + newFileName + fi.Extension;
                if (File.Exists(tmp))
                {
                    File.Delete(tmp);
                }
                fi.CopyTo(tmp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 计算文件的MD5值
        /// </summary>
        /// <param name="fileName">要计算MD5值的文件名和路径</param>
        /// <returns>MD5值16进制字符串</returns>
        public static string MD5File(string fileName)
        {
            return HashFile(fileName, "md5");
        }

        /// <summary>
        /// 计算文件的哈希值
        /// </summary>
        /// <param name="fileName">要计算哈希值的文件名和路径</param>
        /// <param name="algName">算法:sha1,md5</param>
        /// <returns>哈希值16进制字符串</returns>
        private static string HashFile(string fileName, string algName)
        {
            if (!File.Exists(fileName))
            {
                return string.Empty;
            }

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] hashBytes = HashData(fs, algName);
            fs.Close();
            return ByteArrayToHexString(hashBytes);
        }

        /// <summary>
        /// 计算哈希值
        /// </summary>
        /// <param name="stream">要计算哈希值的Stream</param>
        /// <param name="algName">算法:sha1,md5</param>
        /// <returns>哈希值字节数组</returns>
        private static byte[] HashData(Stream stream, string algName)
        {
            HashAlgorithm algorithm;
            if (algName == null)
            {
                throw new ArgumentNullException("algName不能为null");
            }

            if (string.Compare(algName, "sha1", true) == 0)
            {
                algorithm = SHA1.Create();
            }
            else
            {
                if (string.Compare(algName, "md5", true) != 0)
                {
                    throw new Exception("algName只能使用sha1或md5");
                }
                algorithm = MD5.Create();
            }
            return algorithm.ComputeHash(stream);
        }

        /// <summary>
        /// 字节数组转换为16进制表示的字符串
        /// </summary>
        /// <param name="buf">要转换为字节数组</param>
        /// <returns></returns>
        private static string ByteArrayToHexString(byte[] buf)
        {
            return BitConverter.ToString(buf).Replace("-","");
        }
    }
}
