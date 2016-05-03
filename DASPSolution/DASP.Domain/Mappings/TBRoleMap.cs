using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.Domain.Mappings
{
    public class TBRoleMap:BaseMap<TBRoleEntity>
    {
        public TBRoleMap()
        {
            Id(u => u.RoleId).GeneratedBy.Guid();
            Map(u => u.RoleName).Not.Length(20);
            Map(u => u.RoleCode).Not.Length(30);

            Table("T_B_Role");
        }
    }
}
