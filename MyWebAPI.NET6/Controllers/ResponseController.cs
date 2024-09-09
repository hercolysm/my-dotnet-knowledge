using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.NET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        [HttpGet("GetBadRequest")]
        public IActionResult GetBadRequest()
        {
            return BadRequest("Bad Request");
        }

        [HttpGet("GetUnauthorized")]
        public IActionResult GetUnauthorized()
        {
            return Unauthorized("Unauthorized");
        }

        [HttpGet("GetNotFound")]
        public IActionResult GetNotFound()
        {
            return NotFound("Not Found");
        }

        [HttpGet("GetNoContent")]
        public IActionResult GetNoContent()
        {
            return NoContent();
        }

        [HttpGet("GetOk")]
        public IActionResult GetOk()
        {
            return Ok("Ok");
        }

        [HttpGet("GetCreated")]
        public IActionResult GetCreated()
        {
            return Created("api/Response/GetCreated", "Created");
        }

        [HttpGet("GetAccepted")]
        public IActionResult GetAccepted()
        {
            return Accepted("Accepted");
        }

        [HttpGet("GetStatusCode")]
        public IActionResult GetStatusCode()
        {
            return StatusCode(StatusCodes.Status201Created, "Status Code");
        }

        [HttpGet("GetString")]
        public string GetString()
        {
            return "String";
        }

        [HttpGet("GetInt")]
        public int GetInt()
        {
            return 1;
        }

        [HttpGet("GetBool")]
        public bool GetBool()
        {
            return true;
        }
    }
}
