using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.Domain.Mappings
{
    public class TBProjectMap : BaseMap<TBProjectEntity>
    {
        public TBProjectMap()
        {
            Id(u => u.ProjectId).GeneratedBy.Guid();
            Map(u => u.ProjectName).Not.Length(30);
            Map(u => u.ProjectDate).Length(20);
            Map(u => u.ProjectLeader).Length(20);
            Map(u => u.Remark).Length(100);

            References(u => u.Creator).Column("UserId");

            Table("T_B_Project");
        }
    }
}
