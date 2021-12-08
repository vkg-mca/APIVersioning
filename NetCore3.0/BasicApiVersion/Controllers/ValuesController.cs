
using Microsoft.AspNetCore.Mvc;

namespace HeaderApiVersion.Controllers
{

    [ApiController]
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
    [Route("api/values")]
    public class ValuesController : ControllerBase
    {
        // GET api/values?api-version=1.0
        [HttpGet]
        public string Get(ApiVersion apiVersion) => $"Controller = {GetType().Name}\nVersion = {apiVersion}";
    }
}
