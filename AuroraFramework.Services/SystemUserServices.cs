using AuroraFramework.IRepository;
using AuroraFramework.IServices;
using AuroraFramework.Model;
using AuroraFramework.Repository;
using AuroraFramework.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraFramework.Services
{
    public class SystemUserServices : BaseServices<SystemUser>, ISystemUserServices
    {
        ISystemUserRepository _dal;
        public SystemUserServices(ISystemUserRepository dal)
        {
            this._dal = dal;
            base.BaseDAL = dal;
        }

        public async Task<List<SystemUser>> GetSystemUsers()
        {
            return await _dal.Query();
        }
    }
}
