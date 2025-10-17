using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Adminusers(IConfiguration config) : ControllerBase
    {
        private readonly IConfiguration _config = config;

        [HttpGet]
        public IActionResult Users()
        {
            
        }

    }
}
