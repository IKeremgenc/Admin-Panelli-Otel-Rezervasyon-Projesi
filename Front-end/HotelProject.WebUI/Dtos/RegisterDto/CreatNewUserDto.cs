using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreatNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanın Boş Geçemezsiniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadınızı Boş Geçemezsiniz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Ad Kulanıcı Adını Boş Geçemezsiniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Ad Maili Boş Geçemezsiniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Ad Şifreyi Boş Geçemezsiniz")]
        public string Sifre { get; set; }
        [Required(ErrorMessage = "Ad Şifreyi Boş Geçemezsiniz")]
        [Compare ("Sifre", ErrorMessage ="Şifreler aynı değil!")]
        public string SifreTekrar { get; set; }
       
    }
}
