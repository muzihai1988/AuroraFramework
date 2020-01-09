using AuroraFramework.IRepository;
using AuroraFramework.IRepository.Base;
using AuroraFramework.Model;
using AuroraFramework.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraFramework.Repository
{
    public class SystemUserRepository : BaseRepository<SystemUser>, ISystemUserRepository
    {
        public SystemUserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
