using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prometheus.Core.Constants;
using Prometheus.Core.DTOs;
using Prometheus.Core.Interfaces.Services.Account;

namespace Prometheus.Web.Controllers.Account
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route(Constants.Api.Routes.Login.BaseRoute)]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController()
        {
            _loginService = null;// loginService;
        }

        [HttpPost]
        [Route(Constants.Api.Routes.Login.Authenticate)]
        public async Task<IActionResult> UploadFileAsync(AuthenticateRequestDTO dto)
        {
            dto.Token = "asdasdasd";
            //var sss = JsonSerializer.Deserialize<AuthenticateRequestDTO>(dto);
            return Ok(dto);
        }
    }
}
