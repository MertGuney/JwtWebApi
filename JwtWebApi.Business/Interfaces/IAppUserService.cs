using JwtWebApi.Entity.Concrete;
using JwtWebApi.Entity.Dtos.AppUserDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JwtWebApi.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> FindByUserName(string userName);
        Task<bool> CheckPassword(AppUserLoginDto appUserLoginDto);
        Task<List<AppRole>> GetRolesByUserName(string userName);
    }
}
