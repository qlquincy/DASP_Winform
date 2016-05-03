using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    /// <summary>
    /// 采样数据参数表
    /// </summary>
    public class TBTestParameterEntity : BaseEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public virtual Guid ParamId
        {
            get;
            set;
        }

        /// <summary>
        /// 导入文件hash
        /// </summary>
        public virtual string FileHash
        {
            get;
            set;
        }

        /// <summary>
        /// 采样频率
        /// </summary>
        public virtual double SF
        {
            get;
            set;
        }

        /// <summary>
        /// 采样卡版本 如果数值为111,表明STS数据文件中的数据为单精度浮点数方式存储
        /// </summary>
        public virtual int ADVer
        {
            get;
            set;
        }

        /// <summary>
        /// 采样页数
        /// </summary>
        public virtual int Pages
        {
            get;
            set;
        }

        /// <summary>
        /// 采样零头点数
        /// </summary>
        public virtual int ISC
        {
            get;
            set;
        }

        /// <summary>
        /// 采样通道
        /// </summary>
        public virtual int Ch
        {
            get;
            set;
        }

        /// <summary>
        /// 程控增益
        /// </summary>
        public virtual int Gain
        {
            get;
            set;
        }

        /// <summary>
        /// 总采样通道数
        /// </summary>
        public virtual int TotalCh
        {
            get;
            set;
        }

        /// <summary>
        /// 标定值
        /// </summary>
        public virtual double CV
        {
            get;
            set;
        }

        /// <summary>
        /// 工程单位
        /// </summary>
        public virtual string EU
        {
            get;
            set;
        }

        /// <summary>
        /// 与数据文件一一映射
        /// </summary>
        public virtual TBTestDataEntity Data
        {
            get;
            set;
        }
    }
}
