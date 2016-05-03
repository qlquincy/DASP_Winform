using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASPClient.Global
{
    public class UserInfoInstance
    {
         //单例模式
        private static DASP.Domain.Entitys.TBUserEntity _currentLoginUser;

        public static DASP.Domain.Entitys.TBUserEntity CurrentLoginUser
        {
            get
            {
                return _currentLoginUser;
            }
        }

        public static void SetInstance(DASP.Domain.Entitys.TBUserEntity entity)
        {
            _currentLoginUser = entity;
        }
    }
}
