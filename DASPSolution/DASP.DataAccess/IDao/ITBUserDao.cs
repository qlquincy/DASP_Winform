using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.DataAccess.IDao
{
    public interface ITBUserDao
    {
        TBUserEntity QueryUserByLoginName(string loginName);
    }
}
