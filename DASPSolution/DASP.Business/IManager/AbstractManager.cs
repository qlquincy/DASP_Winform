using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASP.DataAccess;

namespace DASP.Business.IManager
{
    public abstract class AbstractManager<T> : IManagerBase<T> where T : class
    {
        public IRepository<T> Dao { get; set; }

        public virtual T Get(object id)
        {
            return this.Dao.Get(id);
        }

        public virtual object Save(T model)
        {
            return this.Dao.Save(model);
        }

        public void Update(T model)
        {
            this.Dao.Update(model);
        }

        public void SaveOrUpdate(T model)
        {
            this.Dao.SaveOrUpdate(model);
        }

        public virtual void Delete(T model)
        {
            this.Dao.Delete(model);
        }

        public void Delete(List<long> idList)
        {
            foreach (long item in idList)
            {
                T model = this.Dao.Get(item);
                if (model != null)
                {
                    this.Dao.Delete(model);
                }
            }
        }


        public virtual IList<T> GetAll()
        {
            return this.Dao.GetAll();
        }
    }
}
