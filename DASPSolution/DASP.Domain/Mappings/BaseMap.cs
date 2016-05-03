using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using DASP.Domain.Entitys;

namespace DASP.Domain.Mappings
{
    public class BaseMap<T> : ClassMap<T> where T : BaseEntity
    {
        protected BaseMap()
        {
            Map(u => u.CreateTime).Length(20);
            Map(u => u.UpdateTime).Length(20);
            Map(u => u.IsDeleted);
        }
    }
}
