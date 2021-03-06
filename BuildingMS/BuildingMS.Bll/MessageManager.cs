using BuildingMS.Dal.Abstract;
using BuildingMS.Entity.Dto;
using BuildingMS.Entity.Models;
using BuildingMS.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Bll
{
    public class MessageManager : GenericManager<Message, DtoMessage>, IMessageService
    {
        public readonly IMessageRepository messageRepository;

        public MessageManager(IServiceProvider service) : base(service)
        {
            messageRepository = service.GetService<IMessageRepository>();

        }
    }
}
