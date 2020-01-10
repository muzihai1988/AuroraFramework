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
        ISystemUserRepository _repository;
        public SystemUserServices(ISystemUserRepository repository)
        {
            this._repository = repository;
            base.BaseRepository = repository;
        }

        public async Task<List<SystemUser>> GetSystemUsers()
        {
            return await _repository.Query();
        }
    }
}
