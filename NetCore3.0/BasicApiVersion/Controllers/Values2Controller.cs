
using Microsoft.AspNetCore.Mvc;

namespace HeaderApiVersion.Controllers
{

    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/values")]
    public class Values2Controller : ControllerBase
    {
        // GET api/values?api-version=1.0
        [HttpGet]
        public string Get(ApiVersion apiVersion) => $"Controller = {GetType().Name}\nVersion = {apiVersion}";
    }
}
