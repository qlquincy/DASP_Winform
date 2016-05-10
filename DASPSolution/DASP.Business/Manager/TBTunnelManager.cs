using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Business.IManager;
using DASP.DataAccess.IDao;

namespace DASP.Business.Manager
{
    public class TBTunnelManager : AbstractManager<DASP.Domain.Entitys.TBTunnelEntity>, ITBTunnelManager
    {
        public IList<Domain.Entitys.TBTunnelEntity> FindForPager(Domain.Common.Pager pager)
        {
            ITBTunnelDao dataDao = Dao as ITBTunnelDao;

            return dataDao.QueryForPager(pager);
        }


        public IList<Domain.Entitys.TBTunnelEntity> FindByProjectId(Guid projectId)
        {
            ITBTunnelDao dataDao = Dao as ITBTunnelDao;
            return dataDao.QueryByProjectId(projectId);
        }
    }
}
