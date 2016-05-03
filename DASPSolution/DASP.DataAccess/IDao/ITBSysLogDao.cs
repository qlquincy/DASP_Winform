using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DASP.Domain.Entitys;

namespace DASP.DataAccess.IDao
{
    public interface ITBSysLogDao
    {
        DataTable QueryByTypeAndDate(int type, DateTime startDate, DateTime dueDate);

        IList<TBSysLogEntity> QuerySysLogsByPageInfo(int pageCode, int pageSize, int? logType, string ip,
            string startTime, string endTime, out long totalPage);
    }
}
