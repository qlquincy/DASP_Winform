using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Domain.Entitys
{
    public class BaseEntity
    {
        public virtual string UpdateTime { get; set; }

        public virtual string CreateTime { get; set; }

        public virtual bool IsDeleted { get; set; }
    }
}
