using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoManagerToken
    {
        public DtoLoginManager DtoLoginManager { get; set; }
        public object AccessToken { get; set; }
    }
}
