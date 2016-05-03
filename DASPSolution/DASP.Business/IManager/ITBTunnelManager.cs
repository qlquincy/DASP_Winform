using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Business.IManager
{
    public interface ITBTunnelManager : IManagerBase<DASP.Domain.Entitys.TBTunnelEntity>
    {
        IList<Domain.Entitys.TBTunnelEntity> FindForPager(Domain.Common.Pager pager);
    }
}
