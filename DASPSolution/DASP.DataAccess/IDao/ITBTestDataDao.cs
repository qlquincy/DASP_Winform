using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Common;

namespace DASP.DataAccess.IDao
{
    public interface ITBTestDataDao
    {
        IList<DASP.Domain.Entitys.TBTestDataEntity> QueryForPager(Pager pager);

        IList<DASP.Domain.Entitys.TBTestDataEntity> QueryByPosId(Guid posId);
    }
}
