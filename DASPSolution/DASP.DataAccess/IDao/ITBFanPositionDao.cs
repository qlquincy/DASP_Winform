using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Common;

namespace DASP.DataAccess.IDao
{
    public interface ITBFanPositionDao
    {
        IList<DASP.Domain.Entitys.TBFanPositionEntity> QueryForPager(Pager pager); 
    }
}
