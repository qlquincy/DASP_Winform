using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;

namespace DASP.DataAccess.Dao
{
    public class TBTestDataDao : NHibernateRepository<DASP.Domain.Entitys.TBTestDataEntity>, ITBTestDataDao
    {

        public IList<Domain.Entitys.TBTestDataEntity> QueryForPager(Domain.Common.Pager pager)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("select count(*) from TBTestDataEntity");

            pager.TotalCount = (int)this.Session.CreateQuery(hqlBuilder.ToString()).UniqueResult<long>();

            hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBTestDataEntity");

            return this.Session.CreateQuery(hqlBuilder.ToString()).SetFirstResult((pager.PageIndex - 1) * pager.PageSize)
                .SetMaxResults(pager.PageSize).List<Domain.Entitys.TBTestDataEntity>();
        }


        public IList<Domain.Entitys.TBTestDataEntity> QueryByPosId(Guid posId)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBTestDataEntity where IsDeleted = false and Position.PositionId = ?");

            return this.HibernateTemplate.Find<Domain.Entitys.TBTestDataEntity>(hqlBuilder.ToString(),posId);
        }
    }
}
