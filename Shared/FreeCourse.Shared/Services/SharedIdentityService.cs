using Microsoft.AspNetCore.Http;

namespace FreeCourse.Shared.Services
{
    public class SharedIdentityService : ISharedIdentityService
    {
        // Bu servisi kullanacak olan API'nın startup class'ına services.AddHttpContextAccessor(); ve scope olarak eklenmeli.
        private IHttpContextAccessor _httpContextAccessor; 

        public SharedIdentityService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
    }
}
