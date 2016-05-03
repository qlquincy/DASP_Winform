using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Core
{
    public class StsData
    {
        /// <summary>
        /// 试点名
        /// </summary>
        public string TestName
        {
            get;
            set;
        }

        /// <summary>
        /// 试点号
        /// </summary>
        public int TestCode
        {
            get;
            set;
        }

        /// <summary>
        /// 测点号
        /// </summary>
        public int ChannelCode
        {
            get;
            set;
        }

        /// <summary>
        /// 文件hash码
        /// </summary>
        public string FileHash
        {
            get;
            set;
        }

        public List<float> Data
        {
            get;
            set;
        }
    }
}
