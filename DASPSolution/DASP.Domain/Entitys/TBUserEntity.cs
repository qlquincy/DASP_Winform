using System;

namespace DASP.Domain.Entitys
{
    public class TBUserEntity : BaseEntity
    {
        /// <summary>
        /// 用户表 -- 主键
        /// </summary>
        public virtual Guid UserId
        {
            get;
            set;
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public virtual string UserName
        {
            get;
            set;
        }

        /// <summary>
        /// 登录名
        /// </summary>
        public virtual string LoginName
        {
            get;
            set;
        }

        /// <summary>
        /// 用户密码
        /// </summary>
        public virtual string UserPassword
        {
            get;
            set;
        }


        /// <summary>
        /// 电话
        /// </summary>
        public virtual string UserTel
        {
            get;
            set;
        }

        /// <summary>
        /// 地址
        /// </summary>
        public virtual string UserAddress
        {
            get;
            set;
        }

        /// <summary>
        /// 邮箱
        /// </summary>
        public virtual string UserEmail
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        public virtual string UserRemark
        {
            get;
            set;
        }

        /// <summary>
        /// 角色
        /// </summary>
        public virtual TBRoleEntity Role 
        { 
            get;
            set;
        }
    }
}