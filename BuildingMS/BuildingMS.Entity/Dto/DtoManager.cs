using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoManager : DtoBase
    {
        public DtoManager()
        {
           
        }

        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerSurname { get; set; }
        public string ManagerMail { get; set; }
        public string ManagerPass { get; set; }
        public string ManagerPhone { get; set; }
        public string ManagerTc { get; set; }
        public string Role { get; set; }
    }
}
