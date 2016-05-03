using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DASP.Core
{
    public class ResolveTspFileAlgorithm
    {
        public static TspConfig ReadDataFromTspFile(string fileName)
        {
            TspConfig config = null;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {

                StreamReader reader = new StreamReader(fileStream);
                string content = reader.ReadLine();
                string[] strArray = content.Trim().Split(',');

                config = new TspConfig();
                config.SF = double.Parse(strArray[0]);
                config.ADVer = int.Parse(strArray[1]);
                config.Pages = int.Parse(strArray[2]);
                config.ISC = int.Parse(strArray[3]);
                config.Ch = int.Parse(strArray[4]);
                config.Gain = int.Parse(strArray[5]);
                config.TotalCh = int.Parse(strArray[6]);
                config.CV = double.Parse(strArray[7]);
                config.EU = strArray[8];
            }

            return config;
        }
    }
}
