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
    public class ManagerManager : GenericManager<Manager, DtoManager>, IManagerService
    {
        public readonly IManagerRepository managerRepository;

        public ManagerManager(IServiceProvider service) : base(service)
        {
            managerRepository = service.GetService<IManagerRepository>();

        }
    }
}
