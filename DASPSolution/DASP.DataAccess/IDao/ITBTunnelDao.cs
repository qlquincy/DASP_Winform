using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Common;

namespace DASP.DataAccess.IDao
{
    public interface ITBTunnelDao
    {
        IList<DASP.Domain.Entitys.TBTunnelEntity> QueryForPager(Pager pager);

        IList<DASP.Domain.Entitys.TBTunnelEntity> QueryByProjectId(Guid projectId);
    }
}
