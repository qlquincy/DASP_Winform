using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;
using FluentNHibernate.Mapping;

namespace DASP.Domain.Mappings
{
    public class TBUserMap : BaseMap<TBUserEntity>
    {
        public TBUserMap()
        {
            Id(u => u.UserId).GeneratedBy.Guid();
            Map(u => u.LoginName).Not.Length(30);
            Map(u => u.UserPassword).Not.Length(50);
            Map(u => u.UserName).Not.Length(30);
            Map(u => u.UserTel).Length(30);
            Map(u => u.UserEmail).Length(20);
            Map(u => u.UserAddress).Length(100);
            Map(u => u.UserRemark).Length(100);

            References(u => u.Role).Column("RoleId").Not.LazyLoad();

            Table("T_B_User");
        }
    }
}
