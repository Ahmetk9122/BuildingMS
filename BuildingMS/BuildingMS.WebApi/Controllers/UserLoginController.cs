using BuildingMS.Entity.Base;
using BuildingMS.Entity.Dto;
using BuildingMS.Entity.IBase;
using BuildingMS.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BuildingMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : ControllerBase
    {
          private readonly IUserLoginService userLoginService;

        public UserLoginController(IUserLoginService userLoginService)
        {
            this.userLoginService = userLoginService;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        //token olmadan da bu işlemi gerçekleştir.
        public IResponse<DtoUserToken> Login(DtoLoginU login)
        {
            try
            {
                return userLoginService.Login(login);
            }
            catch (Exception ex)
            {

                return new Response<DtoUserToken>
                {
                    Message = "Error :" + ex.Message,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }
    }
}
