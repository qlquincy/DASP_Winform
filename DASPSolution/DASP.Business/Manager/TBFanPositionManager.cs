using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Business.IManager;

namespace DASP.Business.Manager
{
    public class TBFanPositionManager : AbstractManager<DASP.Domain.Entitys.TBFanPositionEntity>, ITBFanPositionManager
    {

        public IList<Domain.Entitys.TBFanPositionEntity> FindForPager(Domain.Common.Pager pager)
        {
           DASP.DataAccess.IDao.ITBFanPositionDao posDao = this.Dao as DASP.DataAccess.IDao.ITBFanPositionDao;
           return posDao.QueryForPager(pager);
        }
    }
}
