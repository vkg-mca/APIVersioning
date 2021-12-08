
using Microsoft.AspNetCore.Mvc;

namespace HeaderApiVersion.V1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Route("v{version:apiVersion}/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values?api-version=1.0
        [HttpGet]
        public string Get(ApiVersion apiVersion) => $"Controller = {GetType().Name}\nVersion = {apiVersion}";
    }
}
