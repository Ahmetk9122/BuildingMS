using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoInvoice : DtoBase
    {
        public int InvoiceId { get; set; }
        public string Dues { get; set; }
        public string CommonUsage { get; set; }
        public string InvoiceElectric { get; set; }
        public string InvoiceWater { get; set; }
        public string InvoiceGas { get; set; }
        public int Manager { get; set; }
        public int Users { get; set; }
        public int Apartment { get; set; }
    }
}
