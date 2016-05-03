using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    /// <summary>
    /// 合同表
    /// </summary>
    public class TBProjectEntity : BaseEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public virtual Guid ProjectId
        {
            get;
            set;
        }

        /// <summary>
        /// 合同名称
        /// </summary>
        public virtual string ProjectName
        {
            get;
            set;
        }

        /// <summary>
        /// 合同日期
        /// </summary>
        public virtual string ProjectDate
        {
            get;
            set;
        }

        /// <summary>
        /// 合同创建者
        /// </summary>
        public virtual TBUserEntity Creator
        {
            get;
            set;
        }
 
        /// <summary>
        /// 合同责任人
        /// </summary>
        public virtual string ProjectLeader
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
    }
}
