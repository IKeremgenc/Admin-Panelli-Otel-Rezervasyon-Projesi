using HotelProject.DataAccsesLayer.Concrete;
using HotelProject.WebUI.Dtos.AppUserDto;

using HotelProjectConsume.Models;
using HotelsProject.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit.Encodings;
using System.Linq;

namespace HotelProjectConsume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserLocationController : ControllerBase
    {
        private readonly IAppuserService _appuserService;

        public AppUserLocationController(IAppuserService appuserService)
        {
            _appuserService = appuserService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Context context = new Context();
            var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserListViewModel
            {
                Name = y.Name,
                Surname = y.SurName,
                WorkLocationid = y.WorkLocationid,
                WorkLocationName = y.WorkLocation.WorkLocationName,
                Cinsiyet = y.Cinsiyet,
                Countrey = y.Countrey,
                Sehir=y.Sehir


            }


            ).ToList();

            return Ok(values);


        }
    }
}
