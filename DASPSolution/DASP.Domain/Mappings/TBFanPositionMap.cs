using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.Domain.Mappings
{
    public class TBFanPositionMap : BaseMap<TBFanPositionEntity>
    {
        public TBFanPositionMap()
        {
            Id(u => u.PositionId).GeneratedBy.Guid();

            Map(u => u.PositionName).Not.Length(50);

            Map(u => u.LaneWay);

            Map(u => u.HoleWay);

            Map(u=>u.Ramark).Length(100);

            References(u => u.Tunnel).Column("TunnelId");

            References(u => u.Creator).Column("UserId");

            Table("T_B_FanPosition");
        }
    }
}
