using JwtWebApi.Entity.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JwtWebApi.DataAccess.Interfaces
{
    public interface IAppUserDal : IGenericDal<AppUser>
    {
        Task<List<AppRole>> GetRolesByUserName(string userName);
    }
}
