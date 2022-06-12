using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace BuildingMS.Entity.Models
{
    public partial class Message : EntityBase
    {
        public int MessageId { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public string MessageStatus { get; set; }
        public DateTime? MessageTime { get; set; }

        public virtual User ReceiverNavigation { get; set; }
        public virtual Manager SenderNavigation { get; set; }
    }
}
