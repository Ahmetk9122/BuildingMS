using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BuildingMS.Entity.Models
{
    public partial class Invoice : EntityBase
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

        public virtual Apartment ApartmentNavigation { get; set; }
        public virtual Manager ManagerNavigation { get; set; }
        public virtual User UsersNavigation { get; set; }
    }
}
