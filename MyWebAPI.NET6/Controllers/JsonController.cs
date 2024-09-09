using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.NET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JsonController : ControllerBase
    {
        [HttpGet("GetJson")]
        public IActionResult GetJson()
        {
            var obj = new
            {
                Nome = "João",
                Idade = 25,
                Cidade = "São Paulo"
            };

            return Ok(obj);
        }

        [HttpPost("PostDynamicBody")]
        public IActionResult PostDynamicBody(dynamic body)
        {
            return Ok(body);
        }

        [HttpPost("PostObjectJson")]
        public IActionResult PostObjectJson(RequestModel obj) => Ok(obj);
    }

    public class RequestModel
    {
        public string? Text { get; set; }
        public int Number { get; set; }
        public bool Bool { get; set; }
    }
}
