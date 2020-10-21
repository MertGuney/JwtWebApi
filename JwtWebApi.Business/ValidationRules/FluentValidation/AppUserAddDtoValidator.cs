using FluentValidation;
using JwtWebApi.Entity.Dtos.AppUserDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace JwtWebApi.Business.ValidationRules.FluentValidation
{
    public class AppUserAddDtoValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddDtoValidator()
        {
            RuleFor(I => I.FullName).NotEmpty().WithMessage("Ad Soyad alanı boş bırakılamaz.");
            RuleFor(I => I.UserName).NotEmpty().WithMessage("Kullanıcı ad alanı boş bırakılamaz.");
            RuleFor(I => I.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
        }
    }
}
