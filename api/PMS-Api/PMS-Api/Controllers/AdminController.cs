using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PMS_Api.Enums;
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

        [HttpPut("change-name")]
        public async Task<IActionResult> ChangeNameAsync([FromBody] ChangeNameRequest request, CancellationToken cancellationToken)
        {
            return await adminRepository.UpdateNameAsync(request.UserId, request.NewName, cancellationToken) ? Ok() : Problem();
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAdminAsync([FromBody] CreateAdminRequest request, CancellationToken cancellationToken)
        {
            var result = await adminRepository.CreateAdminAsync(request.AdminName, request.AdminEmail, request.Password, cancellationToken);

            return result switch
            {
                CreateAdminResult.Success => Ok(),
                CreateAdminResult.Duplicate => Conflict(),
                CreateAdminResult.Failure => Problem(),
                _ => Problem()
            };
        }

        [HttpDelete("{adminId}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid adminId, CancellationToken cancellationToken)
        {
            var currentAdminUuid = HttpContext.User.Claims
                .FirstOrDefault(c => c.Type == "Uuid")?.Value;

            if (currentAdminUuid == null)
            {
                return BadRequest();
            }

            var result = await adminRepository.DeleteAdminAsync(adminId, Guid.Parse(currentAdminUuid), cancellationToken);

            return result ? Ok() : Problem();
        }

    }
}
