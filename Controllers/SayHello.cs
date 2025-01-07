using Microsoft.AspNetCore.Mvc;

namespace Say_Hello___Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHello : ControllerBase
    {
        [HttpGet]
        [Route("PersonName/{name}")]
        public IActionResult Hello(string name){
            string sayingHello= $"Hello, {name}! nice to meet you!";
            return Ok(sayingHello);
        }
    }
}