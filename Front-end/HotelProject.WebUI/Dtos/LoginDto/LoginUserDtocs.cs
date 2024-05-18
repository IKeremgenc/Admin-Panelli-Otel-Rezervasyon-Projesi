using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
	public class LoginUserDtocs
	{
        [Required(ErrorMessage ="Kulanıcı Adını Giriniz")]
        public string UserName { get; set; }
		[Required(ErrorMessage = "Şifreyi  Giriniz")]
		public string Password { get; set; }
    }
}
