using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreatServiceDto
    {
        [Required(ErrorMessage ="Servis icon linki giriniz")]
        public string Serviceicon { get; set; }
        [Required(ErrorMessage = "Servis Başlığı giriniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Açıklama Giriniz")]
        [StringLength(100,ErrorMessage ="Açıklma maksimum 100 karakter olabilir")]
        public string Description { get; set; }
    }
}
