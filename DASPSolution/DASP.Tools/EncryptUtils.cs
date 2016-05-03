using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DASP.Tools
{
    public class EncryptUtils
    {
        /// <summary>
        /// MD5加密数据
        /// </summary>
        /// <param name="inputString">明文字符</param>
        /// <returns></returns>
        public static string EncryptFromInputString(string inputString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.Unicode.GetBytes(inputString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;
            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }
            return byte2String;
        }
    }
}
