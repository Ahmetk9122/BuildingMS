using BuildingMS.Dal.Abstract;
using BuildingMS.Entity.Base;
using BuildingMS.Entity.Dto;
using BuildingMS.Entity.IBase;
using BuildingMS.Entity.Models;
using BuildingMS.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Bll
{
    public class ApartmentManager : GenericManager<Apartment, DtoApartment>, IApartmentService
    {
        public readonly IApartmentRepository apartmentRepository;

        public ApartmentManager(IServiceProvider service) : base(service)
        {
            apartmentRepository = service.GetService<IApartmentRepository>();

        }

        public IResponse<List<DtoApartment>> FindApartment(int managerid)
        {
            try
            {
                var list = apartmentRepository.FindApartment(managerid);

                var listDto = list.Select(x => ObjectMapper.Mapper.Map<DtoApartment>(x)).ToList();

                //var entity = ObjectMapper.Mapper.Map<Work, DtoWork>(workRepository.FindDepartmetWork(departmentid));

                return new Response<List<DtoApartment>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = listDto
                };
            }
            catch (Exception ex)
            {

                return new Response<List<DtoApartment>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }
    }
}
