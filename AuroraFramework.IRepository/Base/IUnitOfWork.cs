using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace AuroraFramework.IRepository.Base
{
    /// <summary>
    /// 工作单元
    /// 提供事务操作，减少库的连接次数，数据持久化
    /// 服务于仓储，并在工作单元中初始化上下文，为仓储单元提供上下文对象，由此确保同一上下文对象
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <returns></returns>
        SqlSugarClient GetDBClient();

        /// <summary>
        /// 开始事务
        /// </summary>
        void BeginTran();

        /// <summary>
        /// 提交事务
        /// </summary>
        void CommitTran();

        /// <summary>
        /// 事务回滚
        /// </summary>
        void RollbackTran();
    }
}
