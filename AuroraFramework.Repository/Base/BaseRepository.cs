using AuroraFramework.IRepository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;


namespace AuroraFramework.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        private readonly IUnitOfWork _unitOfWork;
        private SqlSugarClient _dbBase;
        private SqlSugarClient _db
        {
            get
            {
                if (typeof(TEntity).GetTypeInfo().GetCustomAttributes(typeof(SugarTable), true).FirstOrDefault((x => x.GetType() == typeof(SugarTable))) is SugarTable sugarTable && !string.IsNullOrEmpty(sugarTable.TableDescription))
                {
                    _dbBase.ChangeDatabase(sugarTable.TableDescription.ToLower());
                }
                else
                {
                    _dbBase.ChangeDatabase("1");

                }
                return _dbBase;
            }
        }
        internal SqlSugarClient DB { get { return _db; } }

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _dbBase = unitOfWork.GetDBClient();
        }

        public async Task<int> Insert(TEntity entity)
        {
            return await _db.Insertable(entity).ExecuteCommandAsync();
        }

        public async Task<bool> Delete(TEntity entity)
        {
            return await _db.Deleteable(entity).ExecuteCommandHasChangeAsync();
        }

        public async Task<bool> DeleteById(object id)
        {
            return await _db.Deleteable<TEntity>(id).ExecuteCommandHasChangeAsync();
        }

        public async Task<bool> DeleteByIds(object[] ids)
        {
            return await _db.Deleteable<TEntity>().In(ids).ExecuteCommandHasChangeAsync();
        }

        public async Task<TEntity> QueryById(object id)
        {
            return await _db.Queryable<TEntity>().In(id).SingleAsync();
        }

        public async Task<List<TEntity>> QueryByIds(object[] ids)
        {
            return await _db.Queryable<TEntity>().In(ids).ToListAsync();
        }

        public async Task<bool> Update(TEntity entity)
        {
            return await _db.Updateable(entity).ExecuteCommandHasChangeAsync();
        }

        public async Task<List<TEntity>> Query()
        {
            return await _db.Queryable<TEntity>().ToListAsync();
        }
    }
}
