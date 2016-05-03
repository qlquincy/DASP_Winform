using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.Domain.Mappings
{
    public class TBTestDataMap : BaseMap<TBTestDataEntity>
    {
        public TBTestDataMap()
        {
            Id(u => u.DataId).GeneratedBy.Guid();
            Map(u => u.TestName).Not.Nullable().Length(20);
            Map(u => u.TestCode).Not.Nullable();
            Map(u => u.FileHash).Not.Nullable();
            Map(u => u.ChannelCode);
            Map(u => u.DataType);
            Map(u => u.Data).CustomSqlType("text").Column("Data");
            Map(u => u.TestTime);
            Map(u => u.Remark).Length(100);

            Map(u => u.SortCode);

            References(u => u.Creator).Column("UserId");

            References(u => u.Position).Column("PositionId");

            Table("T_B_TestData");
        }
    }
}
