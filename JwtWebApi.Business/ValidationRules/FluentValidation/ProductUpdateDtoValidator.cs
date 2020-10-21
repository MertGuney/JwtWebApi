using FluentValidation;
using JwtWebApi.Entity.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace JwtWebApi.Business.ValidationRules.FluentValidation
{
    public class ProductUpdateDtoValidator : AbstractValidator<ProductUpdateDto>
    {
        public ProductUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(0, int.MaxValue);
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez.");
        }
    }
}
