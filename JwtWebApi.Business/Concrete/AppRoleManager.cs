using JwtWebApi.Business.Interfaces;
using JwtWebApi.DataAccess.Interfaces;
using JwtWebApi.Entity.Concrete;
using System.Threading.Tasks;

namespace JwtWebApi.Business.Concrete
{
    public class AppRoleManager : GenericManager<AppRole>, IAppRoleService
    {
        private readonly IGenericDal<AppRole> _genericDal;
        public AppRoleManager(IGenericDal<AppRole> genericDal) : base(genericDal)
        {
            _genericDal = genericDal;
        }
        //jwtidentityinitializer da rol olusturma ve default admin atama işlemi için / gerek duyulmadı.
        public async Task<AppRole> FindByName(string roleName)
        {
            return await _genericDal.GetByFilter(I => I.Name == roleName);
        }
    }
}
