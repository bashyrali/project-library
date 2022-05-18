using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController:ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello world";
        }
    }
}