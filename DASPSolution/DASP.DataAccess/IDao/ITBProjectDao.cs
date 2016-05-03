using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.DataAccess.IDao
{
    public interface ITBProjectDao
    {
        IList<DASP.Domain.Entitys.TBProjectEntity> QueryAllProjects();
    }
}
