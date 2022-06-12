using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoLoginManager: DtoBase
    {
        public string ManagerName { get; set; }
        public string ManagerSurname { get; set; }
        public string ManagerMail { get; set; }
    }
}
