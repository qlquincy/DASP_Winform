using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Business.IManager;
using DASP.DataAccess.IDao;

namespace DASP.Business.Manager
{
    public class TBSysLogManager : AbstractManager<DASP.Domain.Entitys.TBSysLogEntity>, ITBSysLogManager
    {
        public System.Data.DataTable QueryByTypeAndDate(int Type, DateTime StarDate, DateTime DueDate)
        {
            ITBSysLogDao sysLogDao = Dao as ITBSysLogDao;
            return sysLogDao.QueryByTypeAndDate(Type, StarDate, DueDate);
        }


        public IList<Domain.Entitys.TBSysLogEntity> FindSysLogsByPageInfo(int pageCode, int pageSize, int? logType, string ip,
            string startTime, string endTime, out long totalSize)
        {
            ITBSysLogDao sysLogDao = Dao as ITBSysLogDao;
            return sysLogDao.QuerySysLogsByPageInfo(pageCode, pageSize, logType,ip,startTime,endTime, out totalSize);
        }
    }
}
