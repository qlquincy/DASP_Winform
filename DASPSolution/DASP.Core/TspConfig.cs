using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Core
{
    public class TspConfig
    {

        /// <summary>
        /// 采样频率
        /// </summary>
        public double SF
        {
            get;
            set;
        }

        /// <summary>
        /// 采样卡版本 如果数值为111,表明STS数据文件中的数据为单精度浮点数方式存储
        /// </summary>
        public int ADVer
        {
            get;
            set;
        }

        /// <summary>
        /// 采样页数
        /// </summary>
        public int Pages
        {
            get;
            set;
        }

        /// <summary>
        /// 采样零头点数
        /// </summary>
        public int ISC
        {
            get;
            set;
        }

        /// <summary>
        /// 采样通道
        /// </summary>
        public int Ch
        {
            get;
            set;
        }

        /// <summary>
        /// 程控增益
        /// </summary>
        public int Gain
        {
            get;
            set;
        }

        /// <summary>
        /// 总采样通道数
        /// </summary>
        public int TotalCh
        {
            get;
            set;
        }

        /// <summary>
        /// 标定值
        /// </summary>
        public double CV
        {
            get;
            set;
        }

        /// <summary>
        /// 工程单位
        /// </summary>
        public string EU
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
    }
}
