using BuildingMS.Entity.Dto;
using BuildingMS.Entity.Models;
using BuildingMS.Interface;
using BuildingMS.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildingMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiBaseController<IUserService, User, DtoUser>
    {
        private readonly IUserService userService;

        public UserController(IUserService userService) : base(userService)
        {
            this.userService = userService;

        }
    }
}
