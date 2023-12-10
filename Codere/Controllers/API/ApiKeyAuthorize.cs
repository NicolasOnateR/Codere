using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Codere.Controllers.API
{
    public class ApiKeyAuthorize : Controller
    {
        [AttributeUsage(AttributeTargets.Method)]
        public class ApiKeyAuthorizeAttribute : Attribute, IAuthorizationFilter
        {
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                var apiKey = context.HttpContext.Request.Headers["ApiKey"].FirstOrDefault();

                if (string.IsNullOrEmpty(apiKey) || apiKey != "kkk")
                {
                    context.Result = new UnauthorizedResult();
                }
            }
        }
    }
}
