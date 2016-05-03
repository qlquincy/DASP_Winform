using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;
using System.Data;

namespace DASP.DataAccess.Dao
{
    public class TBSysLogDao : NHibernateRepository<DASP.Domain.Entitys.TBSysLogEntity>, ITBSysLogDao
    {

        public DataTable QueryByTypeAndDate(int Type, DateTime StarDate, DateTime DueDate)
        {
            DataTable result = new DataTable();
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.AppendFormat("SELECT * FROM T_B_SysLog WHERE (logtype_id = {0}) AND (log_datetime BETWEEN '{1}' AND '{2}') order by log_datetime",
                Type.ToString(), StarDate.ToString("yyyy-MM-dd"), DueDate.ToString("yyyy-MM-dd"));

            using (IDbCommand command = this.Session.Connection.CreateCommand())
            {
                command.CommandText = sqlBuilder.ToString();
                using (IDataReader reader = command.ExecuteReader())
                {
                    result.Load(reader);
                }
            }
            return result;
        }


        public IList<Domain.Entitys.TBSysLogEntity> QuerySysLogsByPageInfo(int pageCode, int pageSize, int? logType, string ip,
            string startTime, string endTime, out long totalSize)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append(" select count(*) from TBSysLogEntity sl ");
            hqlBuilder.Append(" where 1=1 ");

            if (null != logType)
            {
                hqlBuilder.Append(" and sl.LogTypeId = ?");
            }

            if (!string.IsNullOrEmpty(ip))
            {
                hqlBuilder.Append(" and sl.LogIp like ?");
            }

            if (!string.IsNullOrEmpty(startTime))
            {
                hqlBuilder.Append(" and sl.LogDatetime >= " + "'" + startTime + "'");
            }

            if (!string.IsNullOrEmpty(endTime))
            {
                hqlBuilder.Append(" and sl.LogDatetime <= " + "'" + endTime + "'");
            }


            NHibernate.IQuery query = this.Session.CreateQuery(hqlBuilder.ToString());
            if (null != logType)
            {
                query.SetInt32(0, logType.Value);
                if (!string.IsNullOrEmpty(ip))
                {
                    query.SetString(1, "%" + ip + "%");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(ip))
                {
                    query.SetString(0, "%" + ip + "%");
                }
            }

            totalSize = query.UniqueResult<long>();

            hqlBuilder = new StringBuilder();
            hqlBuilder.Append(" select sl from TBSysLogEntity sl");
            hqlBuilder.Append(" where 1=1 ");

            if (null != logType)
            {
                hqlBuilder.Append(" and sl.LogTypeId = ?");
            }

            if (!string.IsNullOrEmpty(ip))
            {
                hqlBuilder.Append(" and sl.LogIp like ?");
            }

            if (!string.IsNullOrEmpty(startTime))
            {
                hqlBuilder.Append(" and sl.LogDatetime >= " + "'" + startTime + "'");
            }

            if (!string.IsNullOrEmpty(endTime))
            {
                hqlBuilder.Append(" and sl.LogDatetime <= " + "'" + endTime + "'");
            }

            hqlBuilder.Append(" order by sl.LogDatetime desc");

            query = this.Session.CreateQuery(hqlBuilder.ToString());
            if (null != logType)
            {
                query.SetInt32(0, logType.Value);
                if (!string.IsNullOrEmpty(ip))
                {
                    query.SetString(1, "%" + ip + "%");
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(ip))
                {
                    query.SetString(0, "%" + ip + "%");
                }
            }


            query.SetFirstResult((pageCode - 1) * pageSize);
            query.SetMaxResults(pageSize);

            return query.List<DASP.Domain.Entitys.TBSysLogEntity>();
        }
    }
}
