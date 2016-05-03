using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    public class TBRoleEntity : BaseEntity
    {
        /// <summary>
        /// 角色表 -- 主键
        /// </summary>
        public virtual Guid RoleId
        {
            get;
            set;
        }

        /// <summary>
        /// 角色名
        /// </summary>
        public virtual string RoleName
        {
            get;
            set;
        }

        /// <summary>
        /// 角色编码
        /// </summary>
        public virtual string RoleCode
        {
            get;
            set;
        }
    }
}
