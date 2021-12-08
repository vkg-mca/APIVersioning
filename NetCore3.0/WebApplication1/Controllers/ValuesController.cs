using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
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
