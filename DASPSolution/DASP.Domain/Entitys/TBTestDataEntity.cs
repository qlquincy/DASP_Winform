using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    /// <summary>
    /// 试验采样数据表
    /// </summary>
    public class TBTestDataEntity : BaseEntity
    {
        /// <summary>
        /// 主键编号
        /// </summary>
        public virtual Guid DataId
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
        /// 试验名
        /// </summary>
        public virtual string TestName
        {
            get;
            set;
        }

        /// <summary>
        /// 试验号
        /// </summary>
        public virtual int TestCode
        {
            get;
            set;
        }

        /// <summary>
        /// 通道号 1 or 2
        /// </summary>
        public virtual int ChannelCode
        {
            get;
            set;
        }

        /// <summary>
        /// 数据类型 1 -- N,2 -- m/ss
        /// </summary>
        public virtual byte DataType
        {
            get;
            set;
        }

        /// <summary>
        /// 文件序列号数据
        /// </summary>
        public virtual string Data
        {
            get;
            set;
        }

        /// <summary>
        /// 采样时间
        /// </summary>
        public virtual string TestTime
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 排序号
        /// </summary>
        public virtual int SortCode
        {
            get;
            set;
        }

        /// <summary>
        /// 风机位置
        /// </summary>
        public virtual TBFanPositionEntity Position
        {
            get;
            set;
        }

        /// <summary>
        /// 创建者
        /// </summary>
        public virtual TBUserEntity Creator
        {
            get;
            set;
        }
    }
}
