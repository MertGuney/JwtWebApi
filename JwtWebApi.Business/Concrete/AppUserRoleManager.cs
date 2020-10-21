using JwtWebApi.Business.Interfaces;
using JwtWebApi.DataAccess.Interfaces;
using JwtWebApi.Entity.Concrete;

namespace JwtWebApi.Business.Concrete
{
    public class AppUserRoleManager : GenericManager<AppUserRole>, IAppUserRoleService
    {
        public AppUserRoleManager(IGenericDal<AppUserRole> genericDal) : base(genericDal)
        {
        }
    }
}
