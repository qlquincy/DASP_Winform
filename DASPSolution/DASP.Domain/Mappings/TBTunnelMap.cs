using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.Domain.Mappings
{
    public class TBTunnelMap : BaseMap<TBTunnelEntity>
    {
        public TBTunnelMap()
        {

            Id(u => u.TunnelId).GeneratedBy.Guid();
            Map(u => u.TunnelName).Not.Length(30);
            Map(u => u.TunnelStartDate).Length(20);
            Map(u => u.TunnelEndDate).Length(20);
            Map(u => u.TunnelLeader).Length(20);
            Map(u => u.Remark).Length(100);

            References(u => u.Project).Column("ProjectId").Not.LazyLoad();
            References(u => u.Creator).Column("UserId");

            Table("T_B_Tunnel");
        }
    }
}
