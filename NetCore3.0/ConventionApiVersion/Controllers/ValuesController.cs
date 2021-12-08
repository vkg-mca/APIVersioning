
using Microsoft.AspNetCore.Mvc;

namespace HeaderApiVersion.Controllers
{

    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/values")]
    public class ValuesController : ControllerBase
    {
        // GET api/values?api-version=1.0
        [HttpGet]
        public string Get(ApiVersion apiVersion)
            => $"Controller = {GetType().Name}\nVersion = {apiVersion}";

        // GET api/values/{id}?api-version=1.0
        [HttpGet("{id:int}")]
        public string Get(int id, ApiVersion apiVersion)
            => $"Controller = {GetType().Name}\nId = {id}\nVersion = {apiVersion}";
    }
}
