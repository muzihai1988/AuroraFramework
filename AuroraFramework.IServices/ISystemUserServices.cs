using AuroraFramework.IServices.Base;
using AuroraFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuroraFramework.IServices
{
    public interface ISystemUserServices : IBaseServices<SystemUser>
    {
        Task<List<SystemUser>> GetSystemUsers();
    }
}
