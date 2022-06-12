using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoApartment :DtoBase
    {
        public DtoApartment()
        {
        }

        public int ApartmentId { get; set; }
        public string BuildingsName { get; set; }
        public string ApartmentBlock { get; set; }
        public string ApartmentStatus { get; set; }
        public string ApartmentType { get; set; }
        public string ApartmentFlat { get; set; }
        public string ApartmentNo { get; set; }
        public int ApartmentUser { get; set; }
        public int ApartmentManager { get; set; }
    }
}
