using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess.IDao;
using DASP.Domain.Entitys;

namespace DASP.DataAccess.Dao
{
    public class TBUserDao : NHibernateRepository<DASP.Domain.Entitys.TBUserEntity>, ITBUserDao
    {

        public TBUserEntity QueryUserByLoginName(string loginName)
        {
            StringBuilder hqlBuilder = new StringBuilder();
            hqlBuilder.Append("from TBUserEntity user where user.LoginName = ?");

            TBUserEntity userEntity = this.HibernateTemplate.Find<TBUserEntity>(hqlBuilder.ToString(), loginName).FirstOrDefault();
            return userEntity;
        }
    }
}
