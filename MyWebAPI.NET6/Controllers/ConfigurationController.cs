using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.NET6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : Controller
    {
        private readonly IConfiguration _configuration;

        public ConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("GetString")]
        public IActionResult GetString()
        {
            string configuration = _configuration.GetValue<string>("String");
            return Ok(configuration);
        }

        [HttpGet("GetInt")]
        public IActionResult GetInt()
        {
            int configuration = _configuration.GetValue<int>("Int");
            return Ok(configuration);
        }

        [HttpGet("GetBool")]
        public IActionResult GetBool()
        {
            bool configuration = _configuration.GetValue<bool>("Bool");
            return Ok(configuration);
        }

        [HttpGet("GetArray")]
        public IActionResult GetArray()
        {
            int[] configuration = _configuration.GetSection("Array").Get<int[]>();
            return Ok(configuration);
        }

        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            List<int> configuration = _configuration.GetSection("Array").Get<List<int>>();
            return Ok(configuration);
        }

        [HttpGet("GetObject")]
        public IActionResult GetObject()
        {
            var configuration = _configuration.GetSection("Object").Get<MyObject>();
            return Ok(configuration);
        }

        [HttpGet("GetArrayObject")]
        public IActionResult GetArrayObject()
        {
            var configuration = _configuration.GetSection("ArrayObject").Get<MyObject[]>();
            return Ok(configuration);
        }

        [HttpGet("GetConfigTres")]
        public IActionResult GetConfigTres()
        {
            var configuration = _configuration.GetSection("ConfigUm:ConfigDois:ConfigTres:Prop").Value;
            return Ok(configuration);
        }
    }

    internal class MyObject
    {
        public string String { get; set; }
        public int Int { get; set; }
        public bool Bool { get; set; }
        public int[] Array { get; set; }
    }
}
