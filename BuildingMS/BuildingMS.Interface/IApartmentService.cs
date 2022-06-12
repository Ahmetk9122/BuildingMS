using BuildingMS.Entity.Dto;
using BuildingMS.Entity.IBase;
using BuildingMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Interface
{
    public interface IApartmentService : IGenericService<Apartment, DtoApartment>
    {
        IResponse<List<DtoApartment>> FindApartment(int managerid);
    }
}
