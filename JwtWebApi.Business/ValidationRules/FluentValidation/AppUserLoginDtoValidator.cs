using FluentValidation;
using JwtWebApi.Entity.Dtos.AppUserDtos;

namespace JwtWebApi.Business.ValidationRules.FluentValidation
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez.");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre boş geçilemez.");
        }
    }
}
