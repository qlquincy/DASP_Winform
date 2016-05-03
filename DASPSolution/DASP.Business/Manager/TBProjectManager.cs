using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.Business.IManager;
using DASP.DataAccess.IDao;

namespace DASP.Business.Manager
{
    public class TBProjectManager : AbstractManager<DASP.Domain.Entitys.TBProjectEntity>,ITBProjectManager
    {
        public IList<Domain.Entitys.TBProjectEntity> FindAllProjects()
        {
            ITBProjectDao projectDao = this.Dao as ITBProjectDao;
            return projectDao.QueryAllProjects();
        }
    }
}
