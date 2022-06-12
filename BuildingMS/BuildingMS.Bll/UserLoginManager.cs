using BuildingMS.Dal.Abstract;
using BuildingMS.Entity.Base;
using BuildingMS.Entity.Dto;
using BuildingMS.Entity.IBase;
using BuildingMS.Entity.Models;
using BuildingMS.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Bll
{
    public class UserLoginManager : GenericManager<User, DtoUser>, IUserLoginService
    {
        public readonly IUserLoginRepository userRepository;
        private IConfiguration configuration;

        public UserLoginManager(IServiceProvider service, IConfiguration configuration) : base(service)
        {
            userRepository = service.GetService<IUserLoginRepository>();
            this.configuration = configuration;

        }

        public IResponse<DtoUserToken> Login(DtoLoginU login)
        {
            var user = userRepository.Login(ObjectMapper.Mapper.Map<User>(login));

            if (user != null)
            {
                var dtoUser = ObjectMapper.Mapper.Map<DtoLoginUser>(user);

                var token = new TokenUser(configuration).CreateAccessToken(dtoUser);

                var userToken = new DtoUserToken()
                {
                    DtoLoginUser = dtoUser,
                    AccessToken = token
                };

                return new Response<DtoUserToken>
                {
                    Message = "Token üretildi.",
                    StatusCode = StatusCodes.Status200OK,
                    Data = userToken
                };
            }
            else
            {
                return new Response<DtoUserToken>
                {
                    Message = "Kullanıcı kodu veya parolanız yanlış!",
                    StatusCode = StatusCodes.Status406NotAcceptable,
                    Data = null
                };
            }
        }
    }
}
