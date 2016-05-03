using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;

namespace DASP.DataAccess.Dao
{
    public class TBTestParameterDao : NHibernateRepository<DASP.Domain.Entitys.TBTestParameterEntity>, ITBTestParameterDao
    {

    }
}
