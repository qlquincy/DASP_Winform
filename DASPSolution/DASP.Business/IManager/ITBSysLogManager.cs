using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace DASP.Business.IManager
{
    public interface ITBSysLogManager : IManagerBase<DASP.Domain.Entitys.TBSysLogEntity>
    {
        DataTable QueryByTypeAndDate(int Type, DateTime StarDate, DateTime DueDate);

        IList<DASP.Domain.Entitys.TBSysLogEntity> FindSysLogsByPageInfo(int pageCode, int pageSize, int? logType, string ip,
            string startTime, string endTime, out long totalSize);
    }
}
