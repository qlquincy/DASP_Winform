using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    /// <summary>
    /// 风机位置表
    /// </summary>
    public class TBFanPositionEntity : BaseEntity
    {
        /// <summary>
        /// 风机表主键
        /// </summary>
        public virtual Guid PositionId
        {
            get;
            set;
        }

        /// <summary>
        /// 风机位置名称
        /// </summary>
        public virtual string PositionName
        {
            get;
            set;
        }

        /// <summary>
        /// 所属车道数
        /// </summary>
        public virtual byte LaneWay
        {
            get;
            set;
        }

        /// <summary>
        /// 1--左洞,2--右洞
        /// </summary>
        public virtual byte HoleWay
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string Ramark
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

        /// <summary>
        /// 所属隧道
        /// </summary>
        public virtual TBTunnelEntity Tunnel
        {
            get;
            set;
        } 
    }
}
