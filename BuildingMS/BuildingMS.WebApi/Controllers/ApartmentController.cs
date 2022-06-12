using BuildingMS.Entity.Base;
using BuildingMS.Entity.Dto;
using BuildingMS.Entity.IBase;
using BuildingMS.Entity.Models;
using BuildingMS.Interface;
using BuildingMS.WebApi.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BuildingMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ApiBaseController<IApartmentService, Apartment, DtoApartment>
    {
        private readonly IApartmentService apartmentService;

        public ApartmentController(IApartmentService apartmentService) : base(apartmentService)
        {
            this.apartmentService = apartmentService;

        }
        [HttpGet("FindApartment")]
        public IResponse<List<DtoApartment>> FindApartment(int managerid)
        {
            try
            {
                return apartmentService.FindApartment(managerid);
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
