using AuroraFramework.IRepository.Base;
using AuroraFramework.IServices;
using AuroraFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AuroraFramework.API.Controllers
{
    public class SystemUserController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private ISystemUserServices _systemUserServices;

        public SystemUserController(IUnitOfWork unitOfWork, ISystemUserServices systemUserServices)
        {
            _unitOfWork = unitOfWork;
            _systemUserServices = systemUserServices;
        }

        // GET: api/SystemUser
        [HttpGet]
        public async Task<List<SystemUser>> Get()
        {
            return await _systemUserServices.Query();
        }

        // GET: api/SystemUser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SystemUser
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SystemUser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SystemUser/5
        public void Delete(int id)
        {
        }
    }
}
