using JwtWebApi.Entity.Concrete;
using System.Threading.Tasks;

namespace JwtWebApi.Business.Interfaces
{
    public interface IAppRoleService : IGenericService<AppRole>
    {
        Task<AppRole> FindByName(string roleName);
    }
}
