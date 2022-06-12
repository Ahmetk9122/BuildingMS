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
    public class ManagerController : ApiBaseController<IManagerService, Manager, DtoManager>
    {
        private readonly IManagerService managerService;

        public ManagerController(IManagerService managerService) : base(managerService)
        {
            this.managerService = managerService;

        }
    }
}
