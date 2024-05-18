using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int Roomid { get; set; }

        [Required(ErrorMessage = "Lütfen Oda Numarasını Yazınız")]

        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Görsel Giriniz")]

        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen Fiyat Giriniz")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen Oda Başlığı Bilgisi Giriniz")]
        [StringLength(100,ErrorMessage ="Lütfen 100 Karakter Kulanın")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen Yatak Sayısı Giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen Banyo Giriniz")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama Yazınız")]

        public string Description { get; set; }
    }
}
