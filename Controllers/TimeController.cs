using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex05.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex05.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem do todos Times.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Dados do Time id .");

        }
        [HttpPost]
        public async Task<IActionResult> Post(Time time)
        {
            return Ok("Time castrado com sucesso !!");
        }
    }
}
