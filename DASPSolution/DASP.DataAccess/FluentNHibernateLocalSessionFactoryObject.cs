using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using NHibernate.Cfg;
using Spring.Data.NHibernate;
using FluentNHibernate;


namespace DASP.DataAccess
{
    public class FluentNHibernateLocalSessionFactoryObject : LocalSessionFactoryObject
    {
        /// <summary>
        /// Sets the assemblies to load that contain fluent nhibernate mappings.
        /// </summary>
        /// <value>The mapping assemblies.</value>
        public string[] FluentNHibernateMappingAssemblies
        {
            get;
            set;
        }

        protected override void PostProcessConfiguration(Configuration config)
        {
            base.PostProcessConfiguration(config);
            if (FluentNHibernateMappingAssemblies != null)
            {
                foreach (string assemblyName in FluentNHibernateMappingAssemblies)
                {
                    config.AddMappingsFromAssembly(Assembly.Load(assemblyName));
                }
            }
        }
    }
}
