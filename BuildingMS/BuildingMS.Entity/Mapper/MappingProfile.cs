using AutoMapper;
using BuildingMS.Entity.Dto;
using BuildingMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Mapper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Apartment, DtoApartment>().ReverseMap();
            CreateMap<Invoice, DtoInvoice>().ReverseMap();
            CreateMap<Manager, DtoManager>().ReverseMap();
            CreateMap<Message, DtoMessage>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
            CreateMap<User, DtoLoginUser>();
            CreateMap<Manager, DtoLoginManager>();
            CreateMap<DtoLogin,Manager>();
            CreateMap<DtoLoginU,User>();

        }

    }
}
