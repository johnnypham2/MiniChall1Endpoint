using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiController.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloControllers : ControllerBase
    {
        [HttpGet]
        public string addName(string inputName){
            return $"Hey it's nice to meet you {inputName}";
        }
    }
}