using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.Domain.Mappings
{
    public class TBTestParameterMap:BaseMap<TBTestParameterEntity>
    {
        public TBTestParameterMap()
        {
            Id(u => u.ParamId).GeneratedBy.Foreign("Data");
            Map(u=>u.FileHash).Not.Nullable();
            Map(u => u.SF);
            Map(u => u.ADVer);
            Map(u => u.Pages);
            Map(u => u.ISC);
            Map(u => u.Ch);
            Map(u => u.Gain);
            Map(u => u.TotalCh);
            Map(u => u.CV);
            Map(u => u.EU);

            HasOne(u => u.Data).Constrained();

            Table("T_B_TestParameter");
        }
    }
}
