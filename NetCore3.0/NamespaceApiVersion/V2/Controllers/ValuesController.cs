
using Microsoft.AspNetCore.Mvc;

namespace HeaderApiVersion.V2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("v{version:apiVersion}/[controller]")]
    //[Route( "api/v{version:apiVersion}/[controller]" )]
    public class Values2Controller : ControllerBase
    {
        // GET ~api/v1/values
        [HttpGet]
        public string Get(ApiVersion apiVersion) => $"Controller = {GetType().Name}\nVersion = {apiVersion}";
    }
}
