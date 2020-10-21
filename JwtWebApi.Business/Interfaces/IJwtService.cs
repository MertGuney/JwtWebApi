using JwtWebApi.Entity.Concrete;
using System.Collections.Generic;

namespace JwtWebApi.Business.Interfaces
{
    public interface IJwtService
    {
        string GenerateJwt(AppUser appUser, List<AppRole> appRoles);
    }
}
