using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Business.IManager;
using DASP.DataAccess.IDao;

namespace DASP.Business.Manager
{
    public class TBTestDataManager : AbstractManager<DASP.Domain.Entitys.TBTestDataEntity>, ITBTestDataManager
    {
        public IList<Domain.Entitys.TBTestDataEntity> FindForPager(Domain.Common.Pager pager)
        {
           ITBTestDataDao dataDao = this.Dao as ITBTestDataDao;
           return dataDao.QueryForPager(pager);
        }
    }
}
