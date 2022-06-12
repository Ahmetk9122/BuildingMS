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
    public class UserLoginRepository : GenericRepository<User>, IUserLoginRepository
    {
        public UserLoginRepository(DbContext context) : base(context)
        {
        }

        public User Login(User login)
        {
            var user = dbset.Where(x => x.UserEmail == login.UserEmail && x.UserPass == login.UserPass).SingleOrDefault();
            return user;
        }
    }
}
