using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Interfaces;
using PMS_Api.Model.DbModel;
using PMS_Api.Model.Requests;

namespace PMS_Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/admin")]
    public class AdminController(IUserRepository<Admin> adminRepository) : ControllerBase
    {

        [HttpGet]
        public async Task<IEnumerable<Admin>> GetAllAdminsAsync(CancellationToken cancellationToken)
        {
            var admins = await adminRepository.GetAllAsync(cancellationToken);
            return admins;
        }

        [HttpPut("change-password")]
        public async Task<IActionResult> ChangePasswordAsync([FromBody] ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            return await adminRepository.ChangePasswordAsync(request.UserId, request.NewPassword, cancellationToken) ? Ok() : Problem();
        }
    }
}
