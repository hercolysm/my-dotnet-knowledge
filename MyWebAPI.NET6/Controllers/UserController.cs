using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.NET6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDataHora()
        {
            var obj = new 
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
            };

            return Ok(obj);
        }

        [HttpPost("Editar/{userId}")]
        public IActionResult Edit(string userId)
        {
            var message = $"Contato de ID: '{userId}' editado com sucesso!";
            return Ok(new { message });
        }
    }
}