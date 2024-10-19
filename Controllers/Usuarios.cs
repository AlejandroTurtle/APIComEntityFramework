using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiComEntityFramework.Controllers
{
[ApiController]
[Route("[controller]")]
    public class Usuarios : ControllerBase
    {
    [HttpGet("ObertDataHora")]
        public IActionResult ObertDataHora() 
        {
           var obj = new 
           {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToLongTimeString()           
           };

           return Ok(obj);
        }
    }
}