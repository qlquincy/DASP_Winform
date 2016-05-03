using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASP.Business.IManager
{
    public interface IManagerBase<T> where T : class
    {
        /// <summary>
        /// 通过主键返回对象
        /// </summary>
        /// <param name="id">主键值</param>
        /// <returns></returns>
        T Get(object id);

        /// <summary>
        /// 保存对象
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        object Save(T model);

        /// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="model">实体</param>
        void Update(T model);

        /// <summary>
        /// 保存或更新对象
        /// </summary>
        /// <param name="model">实体</param>
        void SaveOrUpdate(T model);

        /// <summary>
        /// 删除对象
        /// </summary>
        /// <param name="model">实体</param>
        void Delete(T model);

        /// <summary>
        /// 批量删除对象
        /// </summary>
        /// <param name="idList">主键集合</param>
        void Delete(List<long> idList);

        IList<T> GetAll();
    }
}
