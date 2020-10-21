using JwtWebApi.Business.Interfaces;
using JwtWebApi.Entity.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace JwtWebApi.Web.CustomFilters
{
    public class ValidId<TEntity> : IActionFilter where TEntity : class, ITable, new()
    {
        private readonly IGenericService<TEntity> _genericService;
        public ValidId(IGenericService<TEntity> genericService)
        {
            _genericService = genericService;
        }
        public void OnActionExecuted(ActionExecutedContext context) { }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.Where(I => I.Key == "id").FirstOrDefault();
            var checkedId = (int)dictionary.Value;
            var entity = _genericService.GetById(checkedId).Result;
            if (entity == null)
            {
                context.Result = new NotFoundObjectResult($"{checkedId} id'li nesne bulunamadı.");
            }
        }
    }
}
