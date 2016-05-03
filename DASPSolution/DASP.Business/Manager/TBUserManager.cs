using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Business.IManager;
using DASP.Domain.Entitys;
using DASP.DataAccess.IDao;

namespace DASP.Business.Manager
{
    public class TBUserManager : AbstractManager<DASP.Domain.Entitys.TBUserEntity>, ITBUserManager
    {
        public TBUserEntity GetUserByLoginName(string loginName)
        {
            ITBUserDao userDao = Dao as ITBUserDao;
            return userDao.QueryUserByLoginName(loginName);
        }
    }
}
