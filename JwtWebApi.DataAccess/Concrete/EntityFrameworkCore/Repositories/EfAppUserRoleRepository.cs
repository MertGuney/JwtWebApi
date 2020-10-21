using JwtWebApi.DataAccess.Interfaces;
using JwtWebApi.Entity.Concrete;

namespace JwtWebApi.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRoleRepository : EfGenericRepository<AppUserRole>, IAppUserRoleDal
    {
    }
}
