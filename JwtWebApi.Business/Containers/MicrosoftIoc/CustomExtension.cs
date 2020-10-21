using FluentValidation;
using JwtWebApi.Business.Concrete;
using JwtWebApi.Business.Interfaces;
using JwtWebApi.Business.ValidationRules.FluentValidation;
using JwtWebApi.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using JwtWebApi.DataAccess.Interfaces;
using JwtWebApi.Entity.Dtos.AppUserDtos;
using JwtWebApi.Entity.Dtos.ProductDtos;
using Microsoft.Extensions.DependencyInjection;

namespace JwtWebApi.Business.Containers.MicrosoftIoc
{
    public static class CustomExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepository>();
            services.AddScoped<IAppUserRoleService, AppUserRoleManager>();

            services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
            services.AddScoped<IAppRoleService, AppRoleManager>();

            services.AddScoped<IJwtService, JwtManager>();

            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();
            services.AddTransient<IValidator<ProductUpdateDto>, ProductUpdateDtoValidator>();

            services.AddTransient<IValidator<AppUserLoginDto>, AppUserLoginDtoValidator>();

            services.AddTransient<IValidator<AppUserAddDto>, AppUserAddDtoValidator>();
        }
    }
}
