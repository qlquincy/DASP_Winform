using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;

namespace DASP.DataAccess.Dao
{
    public class TBFanPositionDao : NHibernateRepository<DASP.Domain.Entitys.TBFanPositionEntity>, ITBFanPositionDao
    {

        public IList<Domain.Entitys.TBFanPositionEntity> QueryForPager(Domain.Common.Pager pager)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("select count(*) from TBFanPositionEntity");

            pager.TotalCount = (int)this.Session.CreateQuery(hqlBuilder.ToString()).UniqueResult<long>();

            hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBFanPositionEntity");

            return this.Session.CreateQuery(hqlBuilder.ToString()).SetFirstResult((pager.PageIndex - 1) * pager.PageSize)
                .SetMaxResults(pager.PageSize).List<Domain.Entitys.TBFanPositionEntity>();
        }

        public IList<Domain.Entitys.TBFanPositionEntity> QueryByTunnelId(Guid tunnelId)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBFanPositionEntity where IsDeleted = false and Tunnel.TunnelId = ?");

            return this.HibernateTemplate.Find<Domain.Entitys.TBFanPositionEntity>(hqlBuilder.ToString(),tunnelId);
        }
    }
}
