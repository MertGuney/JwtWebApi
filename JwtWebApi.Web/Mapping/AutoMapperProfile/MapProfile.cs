using AutoMapper;
using JwtWebApi.Entity.Concrete;
using JwtWebApi.Entity.Dtos.AppUserDtos;
using JwtWebApi.Entity.Dtos.ProductDtos;

namespace JwtWebApi.Web.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductAddDto>();

            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductUpdateDto>();

            CreateMap<AppUserAddDto, AppUser>();
            CreateMap<AppUser, AppUserAddDto>();

        }
    }
}
