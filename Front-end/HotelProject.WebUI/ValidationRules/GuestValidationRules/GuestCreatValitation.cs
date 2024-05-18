using FluentValidation;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class GuestCreatValitation:AbstractValidator<CreatGuestDto>
    {
        public GuestCreatValitation()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("İsim Boş geçilemez");  
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("soyisim boş geçilemez");
            RuleFor(x=>x.City).NotEmpty().WithMessage("şehir alanı boş geçilemez");
            RuleFor(x=>x.Name).MinimumLength(3).WithMessage("Lütfen en az 3  karakter veri girşi yapınız");
            RuleFor(x=>x.Surname).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girşi yapınız");
            RuleFor(x=>x.City).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girşi yapınız");

            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girşi yapınız");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girşi yapınız");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girşi yapınız");


        }

    }
}
