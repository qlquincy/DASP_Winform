using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Business.IManager
{
    public interface ITBProjectManager : IManagerBase<DASP.Domain.Entitys.TBProjectEntity>
    {
        IList<DASP.Domain.Entitys.TBProjectEntity> FindAllProjects();
    }
}
