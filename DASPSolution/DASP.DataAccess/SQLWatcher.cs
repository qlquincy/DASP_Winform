using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace DASP.DataAccess
{
    /// <summary>
    /// SQL查看器
    /// </summary>
    public class SQLWatcher : EmptyInterceptor
    {
        public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
        {
            return base.OnPrepareStatement(sql);
        }
    }
}
