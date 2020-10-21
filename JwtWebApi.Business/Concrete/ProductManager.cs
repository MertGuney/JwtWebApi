using JwtWebApi.Business.Interfaces;
using JwtWebApi.DataAccess.Interfaces;
using JwtWebApi.Entity.Concrete;

namespace JwtWebApi.Business.Concrete
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        public ProductManager(IGenericDal<Product> genericDal) : base(genericDal)
        {
        }
    }
}
