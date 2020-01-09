using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace AuroraFramework.IRepository.Base
{
    public interface IUnitOfWork
    {
        SqlSugarClient GetDBClient();

        void BeginTran();

        void CommitTran();

        void RollbackTran();
    }
}
