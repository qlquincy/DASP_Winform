using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Domain.Entitys;

namespace DASP.Business.IManager
{
    public interface ITBUserManager : IManagerBase<DASP.Domain.Entitys.TBUserEntity>
    {
        TBUserEntity GetUserByLoginName(string loginName);
    }
}
