using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Business.IManager
{
    public interface ITBFanPositionManager : IManagerBase<DASP.Domain.Entitys.TBFanPositionEntity>
    {
        IList<Domain.Entitys.TBFanPositionEntity> FindForPager(Domain.Common.Pager pager);
    }
}
