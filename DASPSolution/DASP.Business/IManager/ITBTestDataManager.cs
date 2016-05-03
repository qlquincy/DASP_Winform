using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Business.IManager
{
    public interface ITBTestDataManager : IManagerBase<DASP.Domain.Entitys.TBTestDataEntity>
    {
        IList<Domain.Entitys.TBTestDataEntity> FindForPager(Domain.Common.Pager pager);
    }
}
