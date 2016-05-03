using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    /// <summary>
    /// 隧道表
    /// </summary>
    public class TBTunnelEntity : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual Guid TunnelId
        {
            get;
            set;
        }

        /// <summary>
        /// 隧道名称
        /// </summary>
        public virtual string TunnelName
        {
            get;
            set;
        }

        /// <summary>
        /// 隧道责任人
        /// </summary>
        public virtual string TunnelLeader
        {
            get;
            set;
        }

        /// <summary>
        /// 隧道检测开始日期
        /// </summary>
        public virtual string TunnelStartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 隧道检测结束日期
        /// </summary>
        public virtual string TunnelEndDate
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
        /// 合同编号
        /// </summary>
        public virtual TBProjectEntity Project
        {
            get;
            set;
        }

        /// <summary>
        /// 隧道创建者
        /// </summary>
        public virtual TBUserEntity Creator
        {
            get;
            set;
        }
    }
}
