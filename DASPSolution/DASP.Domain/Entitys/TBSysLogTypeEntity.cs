using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    /// <summary>
    /// 日志类型表
    /// </summary>
    public class TBSysLogTypeEntity : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual Guid LogTypeId
        {
            get;
            set;
        }

        /// <summary>
        /// 日志类型
        /// </summary>
        public virtual string LogTypeName
        {
            get;
            set;
        }
    }
}
