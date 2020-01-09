using AuroraFramework.IRepository.Base;
using AuroraFramework.IServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraFramework.Services.Base
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class, new()
    {
        public IBaseRepository<TEntity> BaseDAL;

        public async Task<bool> Delete(TEntity entity)
        {
            return await BaseDAL.Delete(entity);
        }

        public async Task<bool> DeleteById(object id)
        {
            return await BaseDAL.DeleteById(id);
        }

        public async Task<bool> DeleteByIds(object[] ids)
        {
            return await BaseDAL.DeleteByIds(ids);
        }

        public async Task<int> Insert(TEntity entity)
        {
            return await BaseDAL.Insert(entity);
        }

        public async Task<TEntity> QueryById(object id)
        {
            return await BaseDAL.QueryById(id);
        }

        public async Task<List<TEntity>> QueryByIds(object[] ids)
        {
            return await BaseDAL.QueryByIds(ids);
        }

        public async Task<bool> Update(TEntity entity)
        {
            return await BaseDAL.Update(entity);
        }

        public async Task<List<TEntity>> Query()
        {
            return await BaseDAL.Query();
        }
    }
}
