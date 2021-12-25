using FreeCourse.Shared.Dtos;
using FreeCourse.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IIdentityService2
    {
        Task<Response<bool>> SignUp(SignupInput signupInput);

    }
}
