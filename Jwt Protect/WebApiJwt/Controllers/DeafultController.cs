using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeafultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Test()
        {
         return Ok( new CreatToken().Tokencreat());
        }
        [HttpGet("[action]")]
        public IActionResult AdminToekn()
        {
            return Ok(new CreatToken().ToeknCreatAdmin());
        }




        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2() 
        {
            return Ok("Hoşgeldiniz");
        }

        [Authorize(Roles ="admin,visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Toekn girşi yaptı");
        }



    }
}
