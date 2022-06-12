using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BuildingMS.Entity.Models
{
    public partial class User : EntityBase
    {
        public User()
        {
            Apartments = new HashSet<Apartment>();
            Invoices = new HashSet<Invoice>();
            Messages = new HashSet<Message>();
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

        public virtual Manager ManagerNavigation { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
