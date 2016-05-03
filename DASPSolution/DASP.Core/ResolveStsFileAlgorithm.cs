using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DASP.Core
{
    public class ResolveStsFileAlgorithm
    {
        public static StsData ReadDataFromStsFile(string fileName)
        {
            StsData stsData = null;
            List<float> result = new List<float>();
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {

                long dataLength = fileStream.Length;        //总长度
                int dataCount = (int)(dataLength / 4);       //计算数据个数

                BinaryReader reader = new BinaryReader(fileStream); //字节流

                for (int i = 0; i < dataCount; i++)
                {
                    float data = reader.ReadSingle();
                    result.Add(data);
                }
                reader.Close();

                FileInfo fileInfo = new FileInfo(fileName);
                string fName = fileInfo.Name;

                stsData = new StsData();
                stsData.Data = result;
            }


            return stsData;
        }
    }
}
