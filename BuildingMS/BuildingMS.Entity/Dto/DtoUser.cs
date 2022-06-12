using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoUser : DtoBase
    {
        public DtoUser()
        {
           
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
        public string UserPhone { get; set; }
        public string UserTc { get; set; }
        public string UserPlate { get; set; }
        public int Manager { get; set; }
        public string UserRole { get; set; }

    }
}
