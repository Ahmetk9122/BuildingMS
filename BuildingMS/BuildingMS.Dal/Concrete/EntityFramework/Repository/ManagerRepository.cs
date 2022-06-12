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
    public class ManagerRepository : GenericRepository<Manager>, IManagerRepository
    {
        public ManagerRepository(DbContext context) : base(context)
        {
        }
    }
}
