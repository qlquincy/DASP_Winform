using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;

namespace DASP.DataAccess.Dao
{
    public class TBProjectDao : NHibernateRepository<DASP.Domain.Entitys.TBProjectEntity>, ITBProjectDao
    {

        public IList<Domain.Entitys.TBProjectEntity> QueryAllProjects()
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBProjectEntity where IsDeleted = false");

            NHibernate.IQuery query = this.Session.CreateQuery(hqlBuilder.ToString());
            return query.List<Domain.Entitys.TBProjectEntity>();
        }
    }
}
