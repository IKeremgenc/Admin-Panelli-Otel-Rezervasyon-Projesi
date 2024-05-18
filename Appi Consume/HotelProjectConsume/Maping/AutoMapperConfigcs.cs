using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProjectConsume.Maping
{
    public class AutoMapperConfigcs:Profile
    {

        public AutoMapperConfigcs()
        {
            CreateMap<RoomAdDto, Room>();
            CreateMap<Room,RoomAdDto>();



            CreateMap<UpdateRoomDto,Room>().ReverseMap();
           
        }
    }
}
