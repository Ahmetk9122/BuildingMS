using BuildingMS.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Dal.Abstract
{
    public interface IApartmentRepository
    {
        List<Apartment> FindApartment(int managerid);
    }
}
