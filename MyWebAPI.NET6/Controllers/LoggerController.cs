using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.NET6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        private readonly ILogger<LoggerController> _logger;

        public LoggerController(ILogger<LoggerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("LogInformation")]
        public IActionResult LogInformation()
        {
            _logger.LogInformation("LogInformation");
            return Ok();
        }

        [HttpGet("LogWarning")]
        public IActionResult LogWarning()
        {
            _logger.LogWarning("LogWarning");
            return Ok();
        }

        [HttpGet("LogError")]
        public IActionResult LogError()
        {
            _logger.LogError("LogError");
            return Ok();
        }

        [HttpGet("LogCritical")]
        public IActionResult LogCritical()
        {
            _logger.LogCritical("LogCritical");
            return Ok();
        }

        [HttpGet("LogDebug")]
        public IActionResult LogDebug()
        {
            _logger.LogDebug("LogDebug");
            return Ok();
        }

        [HttpGet("LogTrace")]
        public IActionResult LogTrace()
        {
            _logger.LogTrace("LogTrace");
            return Ok();
        }

        [HttpGet("LogWarningWithException")]
        public IActionResult LogWarningWithException()
        {
            try
            {
                throw new Exception("Exception");
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "LogWarningWithException");
            }

            return Ok();
        }
    }
}
