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
    public class UserManager : GenericManager<User, DtoUser>, IUserService
    {
        public readonly IUserRepository userRepository;

        public UserManager(IServiceProvider service) : base(service)
        {
            userRepository = service.GetService<IUserRepository>();

        }
    }
}
