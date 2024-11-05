using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;
using Microsoft.AspNetCore.Authorization;

namespace PMS_Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/admin")]
    public class AdminController : ControllerBase
    {
        private readonly IUserRepository<Admin> _adminRepository;

        public AdminController(IUserRepository<Admin> adminRepository)
        {
            _adminRepository = adminRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Admin>> GetAllAdmins(CancellationToken cancellationToken)
        {
            var admins = await _adminRepository.GetAll(cancellationToken);
            return admins;
        }
    }
}
