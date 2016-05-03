using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spring.Data.NHibernate.Generic.Support;

namespace DASP.DataAccess
{
    /// <summary>
    /// Repository基类
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public abstract class NHibernateRepository<T> : HibernateDaoSupport, IRepository<T> where T : class
    {
        public virtual T Get(object id)
        {
            if (id == null) throw new ArgumentNullException("id");
            return this.HibernateTemplate.Get<T>(id);
        }

        public virtual object Save(T model)
        {
            if (model == null) throw new ArgumentNullException("model");
            return this.HibernateTemplate.Save(model);
        }

        public virtual void Update(T model)
        {
            if (model == null) throw new ArgumentNullException("model");
            this.HibernateTemplate.Update(model);
        }

        public virtual void SaveOrUpdate(T model)
        {
            if (model == null) throw new ArgumentNullException("model");
            this.HibernateTemplate.SaveOrUpdate(model);
        }

        public virtual void Delete(T model)
        {
            if (model == null) throw new ArgumentNullException("model");
            this.HibernateTemplate.Delete(model);
        }

        public virtual void SubmitChanges()
        {
            this.Session.Flush();
        }

        public virtual IList<T> GetAll()
        {
            return this.HibernateTemplate.LoadAll<T>();
        }
    }
}
