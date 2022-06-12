using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoMessage : DtoBase
    {
        public int MessageId { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public string MessageStatus { get; set; }
        public DateTime? MessageTime { get; set; }
    }
}
