using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace DASP.Tools
{
    public class ResourceDynamicReaderUtils
    {
        public static string BuildResourcePath(string resourceName)
        {
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"Resources\");
            return Path.Combine(directoryPath,resourceName);
        }

        public static Bitmap DynamicLoadResourceByResourceName(string resourceName)
        {
            string fileFullName = BuildResourcePath(resourceName);
            if (!File.Exists(fileFullName))
            {
                throw new FileNotFoundException(fileFullName + ",无法找到资源");
            }

            using (FileStream fileStream = File.OpenRead(fileFullName))
            {
                byte[] resourceBuffer = new byte[fileStream.Length];
                fileStream.Read(resourceBuffer, 0, resourceBuffer.Length);
                using (MemoryStream ms = new MemoryStream(resourceBuffer))
                {
                    Bitmap bmp = new Bitmap(ms);
                    return bmp;
                }
            }
        }

        public static byte[] DynamicLoadBytesByResourceName(string resourceName)
        {
            if (File.Exists(resourceName))
            {
                throw new FileNotFoundException(resourceName + ",无法找到资源");
            }


            using (FileStream fileStream = File.OpenRead(resourceName))
            {
                byte[] resourceBuffer = new byte[fileStream.Length];
                fileStream.Read(resourceBuffer, 0, resourceBuffer.Length);
                return resourceBuffer;
            }
        }
    }
}
