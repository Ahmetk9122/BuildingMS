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
    public class MessageController : ApiBaseController<IMessageService, Message, DtoMessage>
    {
        private readonly IMessageService messageService;

        public MessageController(IMessageService messageService) : base(messageService)
        {
            this.messageService = messageService;

        }
    }
}
