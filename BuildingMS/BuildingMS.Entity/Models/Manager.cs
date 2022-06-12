using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BuildingMS.Entity.Models
{
    public partial class Manager : EntityBase
    {
        public Manager()
        {
            Apartments = new HashSet<Apartment>();
            Invoices = new HashSet<Invoice>();
            Messages = new HashSet<Message>();
            Users = new HashSet<User>();
        }

        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string ManagerSurname { get; set; }
        public string ManagerMail { get; set; }
        public string ManagerPass { get; set; }
        public string ManagerPhone { get; set; }
        public string ManagerTc { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
