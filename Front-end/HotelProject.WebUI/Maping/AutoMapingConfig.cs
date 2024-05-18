using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.AppUserDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.ContectDto;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.NewsLatterResultDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Maping
{
    public class AutoMapingConfig : Profile
    {
        public AutoMapingConfig() 
        {
            CreateMap<ResultServiceDto, Services>().ReverseMap();
            CreateMap<UpdateServiceDto, Services>().ReverseMap();
            CreateMap<CreatServiceDto, Services>().ReverseMap();
            CreateMap<CreatNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDtocs, AppUser>().ReverseMap();
            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();
            CreateMap<ResultTestimonial, Testimonial>().ReverseMap();
            CreateMap<ResultStaffDtO, Staff>().ReverseMap();
            CreateMap<CreatSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<CreatBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();
            CreateMap<CreatContectDto, Contect>().ReverseMap();
            CreateMap<CreatGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<ResulAppUserDto, AppUser>().ReverseMap();



        }
    }
}
