using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;

namespace DASP.DataAccess.Dao
{
    public class TBTunnelDao : NHibernateRepository<DASP.Domain.Entitys.TBTunnelEntity>, ITBTunnelDao
    {

        public IList<Domain.Entitys.TBTunnelEntity> QueryForPager(Domain.Common.Pager pager)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("select count(*) from TBTunnelEntity");

            pager.TotalCount = (int)this.Session.CreateQuery(hqlBuilder.ToString()).UniqueResult<long>();

            hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBTunnelEntity");

            return this.Session.CreateQuery(hqlBuilder.ToString()).SetFirstResult((pager.PageIndex - 1) * pager.PageSize)
                .SetMaxResults(pager.PageSize).List<Domain.Entitys.TBTunnelEntity>();
        }

        public IList<Domain.Entitys.TBTunnelEntity> QueryByProjectId(Guid projectId)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBTunnelEntity where IsDeleted = false and Project.ProjectId = ? ");

            return this.HibernateTemplate.Find<Domain.Entitys.TBTunnelEntity>(hqlBuilder.ToString(), projectId);
        }
    }
}
