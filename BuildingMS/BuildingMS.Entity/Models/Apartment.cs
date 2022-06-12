using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BuildingMS.Entity.Models
{
    public partial class Apartment :EntityBase
    {
        public Apartment()
        {
            Invoices = new HashSet<Invoice>();
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

        public virtual Manager ApartmentManagerNavigation { get; set; }
        public virtual User ApartmentUserNavigation { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
