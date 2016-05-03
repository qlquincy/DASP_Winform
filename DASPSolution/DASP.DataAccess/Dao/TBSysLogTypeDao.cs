using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;

namespace DASP.DataAccess.Dao
{
    public class TBSysLogTypeDao : NHibernateRepository<DASP.Domain.Entitys.TBSysLogTypeEntity>, ITBSysLogTypeDao
    {
    }
}
