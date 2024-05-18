using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppuserService _appuser;

        public AppUserController(IAppuserService appuserService)
        {
            _appuser = appuserService;
        }

        //[HttpGet]
        //public IActionResult AppUserList()
        //{
        //    var values = _appuser.TUserWithWorkLocation();
        //    return Ok(values);
        //}
        [HttpGet]
        public IActionResult AppUserList2()
        {
            var values = _appuser.tGetList();
            return Ok(values);
            
           
        }
    }
}
