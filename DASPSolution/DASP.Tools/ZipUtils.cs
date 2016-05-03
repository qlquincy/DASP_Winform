using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace DASP.Tools
{
    public class ZipUtils
    {
        public static MemoryStream Compress(byte[] inBytes)
        {

            MemoryStream outStream = new MemoryStream();

            using (MemoryStream intStream = new MemoryStream(inBytes))
            {
                using (GZipStream compress =new GZipStream(outStream,CompressionMode.Compress))
                {
                    intStream.CopyTo(compress);
                }
            }
            return outStream;
        }


        public static byte[] Decompress(MemoryStream inStream)
        {
            byte[] result = null;

            MemoryStream compressedStream = new MemoryStream(inStream.ToArray());
            using (MemoryStream outStream = new MemoryStream())
            {
                using (GZipStream decompress = new GZipStream(compressedStream, CompressionMode.Decompress))
                {
                    decompress.CopyTo(outStream);
                    result = outStream.ToArray();
                }
            }
            return result;

        }
    }
}
