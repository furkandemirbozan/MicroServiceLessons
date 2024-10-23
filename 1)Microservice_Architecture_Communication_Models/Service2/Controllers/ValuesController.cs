using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Service2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(5000);
            return Ok(123);
        }
    }
}
