using System;

namespace DASP.Domain.Entitys
{

    /// <summary>
    /// 系统日志表
    /// </summary> 
    public class TBSysLogEntity : BaseEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        public virtual Guid SyslogId
        {
            get;
            set;
        }
      
        /// <summary>
        /// 日志产生时间
        /// </summary>
        public virtual string LogDatetime
        {
            get;
            set;
        }

        /// <summary>
        /// 日志内容
        /// </summary>
        public virtual string LogContent
        {
            get;
            set;
        }

        /// <summary>
        /// 模块名称
        /// </summary>
        public virtual string LogModuleName
        {
            get;
            set;
        }

        /// <summary>
        /// 日志类型
        /// </summary>
        public virtual int LogTypeId
        {
            get;
            set;
        }
    }
}