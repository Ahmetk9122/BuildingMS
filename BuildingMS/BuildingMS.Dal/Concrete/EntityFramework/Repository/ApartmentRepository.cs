using BuildingMS.Dal.Abstract;
using BuildingMS.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Dal.Concrete.EntityFramework.Repository
{
    public class ApartmentRepository : GenericRepository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(DbContext context) : base(context)
        {
        }

        public List<Apartment> FindApartment(int managerid)
        {
            return dbset.Where(x => x.ApartmentManager == managerid).ToList();
        }
    }
}
